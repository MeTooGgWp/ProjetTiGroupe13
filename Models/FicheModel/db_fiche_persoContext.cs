using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Models.FicheModel
{
    public partial class db_fiche_persoContext : DbContext
    {
      /*  public db_fiche_persoContext()
        {
        }*/

        public db_fiche_persoContext(DbContextOptions<db_fiche_persoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attaque> Attaques { get; set; }
        public virtual DbSet<BasicInfo> BasicInfos { get; set; }
        public virtual DbSet<CaracteristicManager> CaracteristicManagers { get; set; }
        public virtual DbSet<CharacterMastery> CharacterMasteries { get; set; }
        public virtual DbSet<CharacterStatus> CharacterStatuses { get; set; }
        public virtual DbSet<Competence> Competences { get; set; }
        public virtual DbSet<CompetencesFiche> CompetencesFiches { get; set; }
        public virtual DbSet<Compte> Comptes { get; set; }
        public virtual DbSet<DeathrollManager> DeathrollManagers { get; set; }
        public virtual DbSet<Fiche> Fiches { get; set; }
        public virtual DbSet<HealthPointManager> HealthPointManagers { get; set; }
        public virtual DbSet<MoneyManager> MoneyManagers { get; set; }
        public virtual DbSet<PersonalityAndBackground> PersonalityAndBackgrounds { get; set; }
        public virtual DbSet<SaveRollsManager> SaveRollsManagers { get; set; }
        public virtual DbSet<Sort> Sorts { get; set; }

      /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=db-fiche-perso.database.windows.net,1433;Database=db_fiche_perso;User Id=louispoulet;Password=ProjetGroupe13");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Attaque>(entity =>
            {
                entity.HasKey(e => new { e.IdFiche, e.NomAttaque })
                    .HasName("attaque_pk")
                    .IsClustered(false);

                entity.ToTable("attaque");

                entity.Property(e => e.IdFiche).HasColumnName("id_fiche");

                entity.Property(e => e.NomAttaque)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("nom_attaque");

                entity.Property(e => e.BonusAuDegat).HasColumnName("bonus_au_degat");

                entity.Property(e => e.BonusAuJet).HasColumnName("bonus_au_jet");

                entity.Property(e => e.DeDegat).HasColumnName("de_degat");

                entity.Property(e => e.TypeDegat)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("type_degat");

                entity.HasOne(d => d.IdFicheNavigation)
                    .WithMany(p => p.Attaques)
                    .HasForeignKey(d => d.IdFiche)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("attaque_fiche_id_fiche_fk");
            });

            modelBuilder.Entity<BasicInfo>(entity =>
            {
                entity.HasKey(e => e.IdFiche)
                    .HasName("basic_info_pk")
                    .IsClustered(false);

                entity.ToTable("basic_info");

                entity.HasIndex(e => e.IdFiche, "basic_info_id_fiche_uindex")
                    .IsUnique();

                entity.Property(e => e.IdFiche)
                    .ValueGeneratedNever()
                    .HasColumnName("id_fiche");

                entity.Property(e => e.Classe)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("classe")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Experience).HasColumnName("experience");

                entity.Property(e => e.Niveau).HasColumnName("niveau");

                entity.Property(e => e.NomPersonnage)
                    .HasColumnName("nom_personnage")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Race)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("race")
                    .HasDefaultValueSql("('')");

               entity.HasOne(d => d.IdFicheNavigation)
                    .WithOne(p => p.BasicInfo)
                    .HasForeignKey<BasicInfo>(d => d.IdFiche)
                    .HasConstraintName("basic_info_fiche_id_fiche_fk");
            });

            modelBuilder.Entity<CaracteristicManager>(entity =>
            {
                entity.HasKey(e => e.IdFiche)
                    .HasName("caracteristic_manager_pk")
                    .IsClustered(false);

                entity.ToTable("caracteristic_manager");

                entity.Property(e => e.IdFiche)
                    .ValueGeneratedNever()
                    .HasColumnName("id_fiche");

                entity.Property(e => e.Charisme)
                    .HasColumnName("charisme")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.Constitution)
                    .HasColumnName("constitution")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.Dexterite)
                    .HasColumnName("dexterite")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.Force)
                    .HasColumnName("force")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.Intelligence)
                    .HasColumnName("intelligence")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.Sagesse)
                    .HasColumnName("sagesse")
                    .HasDefaultValueSql("((10))");

                entity.HasOne(d => d.IdFicheNavigation)
                    .WithOne(p => p.CaracteristicManager)
                    .HasForeignKey<CaracteristicManager>(d => d.IdFiche)
                    .HasConstraintName("caracteristic_manager_fiche_id_fiche_fk");
            });

            modelBuilder.Entity<CharacterMastery>(entity =>
            {
                entity.HasKey(e => e.IdFiche)
                    .HasName("character_masteries_pk")
                    .IsClustered(false);

                entity.ToTable("character_masteries");

                entity.HasIndex(e => e.IdFiche, "character_masteries_id_fiche_uindex")
                    .IsUnique();

                entity.Property(e => e.IdFiche)
                    .ValueGeneratedNever()
                    .HasColumnName("id_fiche");

                entity.Property(e => e.Langues)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("langues")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Maitrises)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasColumnName("maitrises")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdFicheNavigation)
                    .WithOne(p => p.CharacterMastery)
                    .HasForeignKey<CharacterMastery>(d => d.IdFiche)
                    .HasConstraintName("character_masteries_fiche_id_fiche_fk");
            });

            modelBuilder.Entity<CharacterStatus>(entity =>
            {
                entity.HasKey(e => e.IdFiche)
                    .HasName("character_status_pk")
                    .IsClustered(false);

                entity.ToTable("character_status");

                entity.HasIndex(e => e.IdFiche, "character_status_id_fiche_uindex")
                    .IsUnique();

                entity.Property(e => e.IdFiche)
                    .ValueGeneratedNever()
                    .HasColumnName("id_fiche");

                entity.Property(e => e.ClasseArmure)
                    .HasColumnName("classe_armure")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.Initiative).HasColumnName("initiative");

                entity.Property(e => e.Vitesse)
                    .HasColumnName("vitesse")
                    .HasDefaultValueSql("((9))");

                entity.HasOne(d => d.IdFicheNavigation)
                    .WithOne(p => p.CharacterStatus)
                    .HasForeignKey<CharacterStatus>(d => d.IdFiche)
                    .HasConstraintName("character_status_fiche_id_fiche_fk");
            });

            modelBuilder.Entity<Competence>(entity =>
            {
                entity.HasKey(e => e.IdComp)
                    .HasName("competences_pk")
                    .IsClustered(false);

                entity.ToTable("competences");

                entity.Property(e => e.IdComp).HasColumnName("id_comp");

                entity.Property(e => e.NomComp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nom_comp");
            });

            modelBuilder.Entity<CompetencesFiche>(entity =>
            {
                entity.HasKey(e => new { e.IdComp, e.IdFiche })
                    .HasName("competences_fiche_pk")
                    .IsClustered(false);

                entity.ToTable("competences_fiche");

                entity.Property(e => e.IdComp).HasColumnName("id_comp");

                entity.Property(e => e.IdFiche).HasColumnName("id_fiche");

                entity.HasOne(d => d.IdCompNavigation)
                    .WithMany(p => p.CompetencesFiches)
                    .HasForeignKey(d => d.IdComp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("competences_fiche_competences_id_comp_fk");

                entity.HasOne(d => d.IdFicheNavigation)
                    .WithMany(p => p.CompetencesFiches)
                    .HasForeignKey(d => d.IdFiche)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("competences_fiche_fiche_id_fiche_fk");
            });

            modelBuilder.Entity<Compte>(entity =>
            {
                entity.HasKey(e => e.Pseudo)
                    .HasName("PK__compte__EA0EEA23F3248C3D");

                entity.ToTable("compte");

                entity.HasIndex(e => e.Identifiant, "compte_identifiant_uindex")
                    .IsUnique();

                entity.Property(e => e.Pseudo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pseudo");

                entity.Property(e => e.Identifiant)
                    .IsRequired()
                    .HasMaxLength(320)
                    .IsUnicode(false)
                    .HasColumnName("identifiant");

                entity.Property(e => e.Mdp)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("mdp")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DeathrollManager>(entity =>
            {
                entity.HasKey(e => e.IdFiche)
                    .HasName("deathroll_manager_pk")
                    .IsClustered(false);

                entity.ToTable("deathroll_manager");

                entity.HasIndex(e => e.IdFiche, "deathroll_manager_id_fiche_uindex")
                    .IsUnique();

                entity.Property(e => e.IdFiche)
                    .ValueGeneratedNever()
                    .HasColumnName("id_fiche");

                entity.Property(e => e.EchecJdsContreMort).HasColumnName("echec_jds_contre_mort");

                entity.Property(e => e.SuccesJdsContreMort).HasColumnName("succes_jds_contre_mort");

                entity.HasOne(d => d.IdFicheNavigation)
                    .WithOne(p => p.DeathrollManager)
                    .HasForeignKey<DeathrollManager>(d => d.IdFiche)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deathroll_manager_fiche_id_fiche_fk");
            });

            modelBuilder.Entity<Fiche>(entity =>
            {
                entity.HasKey(e => e.IdFiche)
                    .HasName("fiche_pk_2")
                    .IsClustered(false);

                entity.ToTable("fiche");

                entity.HasIndex(e => e.IdFiche, "fiche_pk")
                    .IsUnique();

                entity.Property(e => e.IdFiche).HasColumnName("id_fiche");

                entity.Property(e => e.CapaciteEtTrait)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("capacite_et_trait");

                entity.Property(e => e.Equipement)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("equipement");

                entity.Property(e => e.IdJoueur)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_joueur");

                entity.Property(e => e.Inspiration).HasColumnName("inspiration");

                entity.Property(e => e.NoteJoueur)
                    .IsRequired()
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("note_joueur");

                entity.HasOne(d => d.IdJoueurNavigation)
                    .WithMany(p => p.Fiches)
                    .HasForeignKey(d => d.IdJoueur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fiche_compte_pseudo_fk");
            });

            modelBuilder.Entity<HealthPointManager>(entity =>
            {
                entity.HasKey(e => e.IdFiche)
                    .HasName("health_point_manager_pk")
                    .IsClustered(false);

                entity.ToTable("health_point_manager");

                entity.HasIndex(e => e.IdFiche, "health_point_manager_id_fiche_uindex")
                    .IsUnique();

                entity.Property(e => e.IdFiche)
                    .ValueGeneratedNever()
                    .HasColumnName("id_fiche");

                entity.Property(e => e.DesDeVie).HasColumnName("des_de_vie");

                entity.Property(e => e.PvActuel).HasColumnName("pv_actuel");

                entity.Property(e => e.PvMax).HasColumnName("pv_max");

                entity.Property(e => e.PvTemporaire).HasColumnName("pv_temporaire");

                entity.HasOne(d => d.IdFicheNavigation)
                    .WithOne(p => p.HealthPointManager)
                    .HasForeignKey<HealthPointManager>(d => d.IdFiche)
                    .HasConstraintName("health_point_manager_fiche_id_fiche_fk");
            });

            modelBuilder.Entity<MoneyManager>(entity =>
            {
                entity.HasKey(e => e.IdFiche)
                    .HasName("money_manager_pk")
                    .IsClustered(false);

                entity.ToTable("money_manager");

                entity.HasIndex(e => e.IdFiche, "money_manager_id_fiche_uindex")
                    .IsUnique();

                entity.Property(e => e.IdFiche)
                    .ValueGeneratedNever()
                    .HasColumnName("id_fiche");

                entity.Property(e => e.PieceArgent).HasColumnName("piece_argent");

                entity.Property(e => e.PieceCuivre).HasColumnName("piece_cuivre");

                entity.Property(e => e.PieceElectrum).HasColumnName("piece_electrum");

                entity.Property(e => e.PieceOr).HasColumnName("piece_or");

                entity.Property(e => e.PiecePlatine).HasColumnName("piece_platine");

                entity.HasOne(d => d.IdFicheNavigation)
                    .WithOne(p => p.MoneyManager)
                    .HasForeignKey<MoneyManager>(d => d.IdFiche)
                    .HasConstraintName("money_manager_fiche_id_fiche_fk");
            });

            modelBuilder.Entity<PersonalityAndBackground>(entity =>
            {
                entity.HasKey(e => e.IdFiche)
                    .HasName("personality_and_background_pk")
                    .IsClustered(false);

                entity.ToTable("personality_and_background");

                entity.HasIndex(e => e.IdFiche, "personality_and_background_id_fiche_uindex")
                    .IsUnique();

                entity.Property(e => e.IdFiche)
                    .ValueGeneratedNever()
                    .HasColumnName("id_fiche");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Alignement)
                    .HasColumnName("alignement")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.AllieEtOrganisation)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("allie_et_organisation")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Apparence)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("apparence")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Background)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("background")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Defauts)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("defauts")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Historique)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("historique")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ideaux)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ideaux")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Liens)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("liens")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TraitDePersonnalite)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("trait_de_personnalite")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdFicheNavigation)
                    .WithOne(p => p.PersonalityAndBackground)
                    .HasForeignKey<PersonalityAndBackground>(d => d.IdFiche)
                    .HasConstraintName("personality_and_background_fiche_id_fiche_fk");
            });

            modelBuilder.Entity<SaveRollsManager>(entity =>
            {
                entity.HasKey(e => e.IdFiche)
                    .HasName("save_rolls_manager_pk")
                    .IsClustered(false);

                entity.ToTable("save_rolls_manager");

                entity.HasIndex(e => e.IdFiche, "save_rolls_manager_id_fiche_uindex")
                    .IsUnique();

                entity.Property(e => e.IdFiche)
                    .ValueGeneratedNever()
                    .HasColumnName("id_fiche");

                entity.Property(e => e.JdsCharisme).HasColumnName("jds_charisme");

                entity.Property(e => e.JdsConstitution).HasColumnName("jds_constitution");

                entity.Property(e => e.JdsDexterite).HasColumnName("jds_dexterite");

                entity.Property(e => e.JdsForce).HasColumnName("jds_force");

                entity.Property(e => e.JdsIntelligence).HasColumnName("jds_intelligence");

                entity.Property(e => e.JdsSagesse).HasColumnName("jds_sagesse");

                entity.HasOne(d => d.IdFicheNavigation)
                    .WithOne(p => p.SaveRollsManager)
                    .HasForeignKey<SaveRollsManager>(d => d.IdFiche)
                    .HasConstraintName("save_rolls_manager_fiche_id_fiche_fk");
            });

            modelBuilder.Entity<Sort>(entity =>
            {
                entity.HasKey(e => new {e.IdSort,e.IdFiche})
                    .HasName("sorts_pk")
                    .IsClustered(false);

                entity.ToTable("sorts");

                entity.Property(e => e.IdSort).HasColumnName("id_sort");

                entity.Property(e => e.DescriptionSort)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("description_sort");

                entity.Property(e => e.IdFiche).HasColumnName("id_fiche");

                entity.Property(e => e.NiveauSort).HasColumnName("niveau_sort");

                entity.Property(e => e.NomSort)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nom_sort");

                entity.HasOne(d => d.IdFicheNavigation)
                    .WithMany(p => p.Sorts)
                    .HasForeignKey(d => d.IdFiche)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sorts_fiche_id_fiche_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
