using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Infrastructure;
using Infrastructure.Factories;
using ProjetctTiGr13.Domain;

namespace ProjetctTiGr13.Infrastructure
{

    //c'est avec cette classe que nous allons inscrire les requêtes sql
    public class SqlServerFicheRepository : IFicheRepository
    {

        //Liste des requêtes : 

        //requête pour avoir toutes les fiches : 
        public static readonly string reqQueryAll = $"SELECT * FROM {IFicheColumnsName.TableName}";

        //Requête pour avoir toutes les fiches d'un utilisateur :

        public static string ReqQueryUser =
            reqQueryAll + $" where {IFicheColumnsName.colId_joueur} = @{IFicheColumnsName.colId_joueur}";

        //Requete pour avoir une fiche précise d'un utilisateur (celui connecté en outre):

        public static string ReqGet =
            ReqQueryUser + $"AND {IFicheColumnsName.colId_fiche} = @{IFicheColumnsName.colId_fiche}";




        //requete CREATE : 
        public static string reqCreate = $@"
       INSERT INTO {IFicheColumnsName.TableName}(
            {IFicheColumnsName.colId_joueur},
            {IFicheColumnsName.colForce_carac},
            {IFicheColumnsName.colDexterite_carac},
            {IFicheColumnsName.colConstition_carac},
            {IFicheColumnsName.colIntelligence_carac},
            {IFicheColumnsName.colSagesse_carac},
            {IFicheColumnsName.colCharisme_carac},
            {IFicheColumnsName.colJds_force},
            {IFicheColumnsName.colJds_dexterite},
            {IFicheColumnsName.colJds_constitution},
            {IFicheColumnsName.colJds_intelligence},
            {IFicheColumnsName.colJds_sagesse},
            {IFicheColumnsName.colJds_charisme},
            {IFicheColumnsName.colInspiration},
            {IFicheColumnsName.colClasse_armure},
            {IFicheColumnsName.colInitiative},
            {IFicheColumnsName.colVitesse},
            {IFicheColumnsName.colPv_max},
            {IFicheColumnsName.colPv_actuel},
            {IFicheColumnsName.colPv_temporaire},
            {IFicheColumnsName.colDes_de_vie},
            {IFicheColumnsName.colSucces_jds_contre_mort},
            {IFicheColumnsName.colEchec_jds_contre_mort},
            {IFicheColumnsName.colMaitrises},
            {IFicheColumnsName.colLangues},
            {IFicheColumnsName.colPiece_cuivre},
            {IFicheColumnsName.colPiece_argent},
            {IFicheColumnsName.colPiece_or},
            {IFicheColumnsName.colPiece_electrum},
            {IFicheColumnsName.colPiece_platine},
            {IFicheColumnsName.colEquipement},
            {IFicheColumnsName.colCapacite_et_trait},
            {IFicheColumnsName.colTrait_de_personnalite},
            {IFicheColumnsName.colIdeaux},
            {IFicheColumnsName.colLiens},
            {IFicheColumnsName.colDefauts},
            {IFicheColumnsName.colAlignement},
            {IFicheColumnsName.colHistorique},
            {IFicheColumnsName.colAge},
            {IFicheColumnsName.colApparence},
            {IFicheColumnsName.colAllie_et_organisation},
            {IFicheColumnsName.colBackground},
            {IFicheColumnsName.colClasse},
            {IFicheColumnsName.colNiveau},
            {IFicheColumnsName.colRace},
            {IFicheColumnsName.colNom_personnage},
            {IFicheColumnsName.colExperience},
            {IFicheColumnsName.colNote_joueur}) 

        OUTPUT INSERTED.{IFicheColumnsName.colId_fiche}  
        values(
            @{IFicheColumnsName.colId_joueur},
            @{IFicheColumnsName.colForce_carac},
            @{IFicheColumnsName.colDexterite_carac},
            @{IFicheColumnsName.colConstition_carac},
            @{IFicheColumnsName.colIntelligence_carac},
            @{IFicheColumnsName.colSagesse_carac},
            @{IFicheColumnsName.colCharisme_carac},
            @{IFicheColumnsName.colJds_force},
            @{IFicheColumnsName.colJds_dexterite},
            @{IFicheColumnsName.colJds_constitution},
            @{IFicheColumnsName.colJds_intelligence},
            @{IFicheColumnsName.colJds_sagesse},
            @{IFicheColumnsName.colJds_charisme},
            @{IFicheColumnsName.colInspiration},
            @{IFicheColumnsName.colClasse_armure},
            @{IFicheColumnsName.colInitiative},
            @{IFicheColumnsName.colVitesse},
            @{IFicheColumnsName.colPv_max},
            @{IFicheColumnsName.colPv_actuel},
            @{IFicheColumnsName.colPv_temporaire},
            @{IFicheColumnsName.colDes_de_vie},
            @{IFicheColumnsName.colSucces_jds_contre_mort},
            @{IFicheColumnsName.colEchec_jds_contre_mort},
            @{IFicheColumnsName.colMaitrises},
            @{IFicheColumnsName.colLangues},
            @{IFicheColumnsName.colPiece_cuivre},
            @{IFicheColumnsName.colPiece_argent},
            @{IFicheColumnsName.colPiece_or},
            @{IFicheColumnsName.colPiece_electrum},
            @{IFicheColumnsName.colPiece_platine},
            @{IFicheColumnsName.colEquipement},
            @{IFicheColumnsName.colCapacite_et_trait},
            @{IFicheColumnsName.colTrait_de_personnalite},
            @{IFicheColumnsName.colIdeaux},
            @{IFicheColumnsName.colLiens},
            @{IFicheColumnsName.colDefauts},
            @{IFicheColumnsName.colAlignement},
            @{IFicheColumnsName.colHistorique},
            @{IFicheColumnsName.colAge},
            @{IFicheColumnsName.colApparence},
            @{IFicheColumnsName.colAllie_et_organisation},
            @{IFicheColumnsName.colBackground},
            @{IFicheColumnsName.colClasse},
            @{IFicheColumnsName.colNiveau},
            @{IFicheColumnsName.colRace},
            @{IFicheColumnsName.colNom_personnage},
            @{IFicheColumnsName.colExperience},
            @{IFicheColumnsName.colNote_joueur})";




        //requete DELETE : 
        public static readonly string reqDelete =
            $"DELETE FROM {IFicheColumnsName.TableName} WHERE {IFicheColumnsName.colId_fiche} = @{IFicheColumnsName.colId_fiche}";


        //Requete UPDATE : 

        public static readonly string reqUpdate = $@"
        UPDATE {IFicheColumnsName.TableName} SET
            {IFicheColumnsName.colId_joueur} = @{IFicheColumnsName.colId_joueur},
            {IFicheColumnsName.colForce_carac} = @{IFicheColumnsName.colForce_carac},
            {IFicheColumnsName.colDexterite_carac} = @{IFicheColumnsName.colDexterite_carac},
            {IFicheColumnsName.colConstition_carac} = @{IFicheColumnsName.colConstition_carac},
            {IFicheColumnsName.colIntelligence_carac} = @{IFicheColumnsName.colIntelligence_carac},
            {IFicheColumnsName.colSagesse_carac} = @{IFicheColumnsName.colSagesse_carac},
            {IFicheColumnsName.colCharisme_carac} = @{IFicheColumnsName.colCharisme_carac},
            {IFicheColumnsName.colJds_force} = @{IFicheColumnsName.colJds_force},
            {IFicheColumnsName.colJds_dexterite} = @{IFicheColumnsName.colJds_dexterite},
            {IFicheColumnsName.colJds_constitution} = @{IFicheColumnsName.colJds_constitution},
            {IFicheColumnsName.colJds_intelligence} = @{IFicheColumnsName.colJds_intelligence},
            {IFicheColumnsName.colJds_sagesse} = @{IFicheColumnsName.colJds_sagesse},
            {IFicheColumnsName.colJds_charisme} = @{IFicheColumnsName.colJds_charisme},
            {IFicheColumnsName.colInspiration} = @{IFicheColumnsName.colInspiration},
            {IFicheColumnsName.colClasse_armure} = @{IFicheColumnsName.colClasse_armure},
            {IFicheColumnsName.colInitiative} = @{IFicheColumnsName.colInitiative},
            {IFicheColumnsName.colVitesse} = @{IFicheColumnsName.colVitesse},
            {IFicheColumnsName.colPv_max} = @{IFicheColumnsName.colPv_max},
            {IFicheColumnsName.colPv_actuel} =@{IFicheColumnsName.colPv_actuel},
            {IFicheColumnsName.colPv_temporaire} = @{IFicheColumnsName.colPv_temporaire},
            {IFicheColumnsName.colDes_de_vie}=@{IFicheColumnsName.colDes_de_vie},
            {IFicheColumnsName.colSucces_jds_contre_mort}=@{IFicheColumnsName.colSucces_jds_contre_mort},
            {IFicheColumnsName.colEchec_jds_contre_mort}=@{IFicheColumnsName.colEchec_jds_contre_mort},
            {IFicheColumnsName.colMaitrises}=@{IFicheColumnsName.colMaitrises},
            {IFicheColumnsName.colLangues}=@{IFicheColumnsName.colLangues},
            {IFicheColumnsName.colPiece_cuivre}=@{IFicheColumnsName.colPiece_cuivre},
            {IFicheColumnsName.colPiece_argent}=@{IFicheColumnsName.colPiece_argent},
            {IFicheColumnsName.colPiece_or}=@{IFicheColumnsName.colPiece_or},
            {IFicheColumnsName.colPiece_electrum}=@{IFicheColumnsName.colPiece_electrum},
            {IFicheColumnsName.colPiece_platine}=@{IFicheColumnsName.colPiece_platine},
            {IFicheColumnsName.colEquipement}=@{IFicheColumnsName.colEquipement},
            {IFicheColumnsName.colCapacite_et_trait}=@{IFicheColumnsName.colCapacite_et_trait},
            {IFicheColumnsName.colTrait_de_personnalite} = @{IFicheColumnsName.colTrait_de_personnalite},
            {IFicheColumnsName.colIdeaux} = @{IFicheColumnsName.colIdeaux},
            {IFicheColumnsName.colLiens} = @{IFicheColumnsName.colLiens},
            {IFicheColumnsName.colDefauts} = @{IFicheColumnsName.colDefauts},
            {IFicheColumnsName.colAlignement} = @{IFicheColumnsName.colAlignement},
            {IFicheColumnsName.colHistorique} = @{IFicheColumnsName.colHistorique},
            {IFicheColumnsName.colAge} = @{IFicheColumnsName.colAge},
            {IFicheColumnsName.colApparence} = @{IFicheColumnsName.colApparence},
            {IFicheColumnsName.colAllie_et_organisation} = @{IFicheColumnsName.colAllie_et_organisation},
            {IFicheColumnsName.colBackground} = @{IFicheColumnsName.colBackground},
            {IFicheColumnsName.colClasse} = @{IFicheColumnsName.colClasse};
            {IFicheColumnsName.colNiveau} = @{IFicheColumnsName.colNiveau},
            {IFicheColumnsName.colRace}=@{IFicheColumnsName.colRace},
            {IFicheColumnsName.colNom_personnage}=@{IFicheColumnsName.colNom_personnage},
            {IFicheColumnsName.colExperience}=@{IFicheColumnsName.colExperience},
            {IFicheColumnsName.colNote_joueur}=@{IFicheColumnsName.colNote_joueur}) 
            WHERE {IFicheColumnsName.colId_fiche} = @{IFicheColumnsName.colId_fiche}
";




        //Afin de pouvoir "créer" un objet fiche à partir des données de la bd :
        private IInstanceFromReaderFactory<IFiche> _instanceFromReaderFactory = new FicheFactory();

        
        
        
        
        
        
        
        
        
        
        //METHODS A PARTIR D'ICI !!!!
        public IEnumerable<IFiche> QueryAll()
        {
            IList<IFiche> fiches = new List<IFiche>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = reqQueryAll;

                var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    fiches.Add(_instanceFromReaderFactory.CreateFromReader(reader));
                }
            }

            return fiches;
        }

        public IEnumerable<IFiche> QueryByPlayer(string id_joueur)
        {
            IList<IFiche> fiches = new List<IFiche>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = ReqQueryUser;

                command.Parameters.AddWithValue($@"{IFicheColumnsName.colId_joueur}", id_joueur);

                var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    fiches.Add(_instanceFromReaderFactory.CreateFromReader(reader));
                }
            }

            return fiches;
        }

        public IFiche Get(int id_fiche, string id_joueur)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = ReqGet;

                command.Parameters.AddWithValue($@"{IFicheColumnsName.colId_joueur}", id_joueur);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colId_fiche}", id_fiche);

                var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                return reader.Read() ? _instanceFromReaderFactory.CreateFromReader(reader) : null;
            }
        }

        public IFiche Create(IFiche fiche)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = reqCreate;

                CommandBloc(command,fiche);

                fiche.IdFiche = (int) command.ExecuteScalar();
            }

            return fiche;
        }

        public bool Delete(int id_fiche)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = reqDelete;

                command.Parameters.AddWithValue($"@{IFicheColumnsName.colId_fiche}", id_fiche);

                return command.ExecuteNonQuery() == 1;
            }
        }

        public bool Update(int id_fiche, string id_joueur, IFiche fiche)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = reqUpdate;
                
                CommandBloc(command,fiche);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colId_fiche}", id_fiche);


                return command.ExecuteNonQuery() == 1;
            }
        }

    //Bloc commun au méthode UPDATE ET CREATE
        private void CommandBloc(SqlCommand command,IFiche fiche)
        {
             command.Parameters.AddWithValue($"@{IFicheColumnsName.colId_joueur}",fiche.IdJoueur);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colForce_carac}",fiche.Caracteristics.Force);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colDexterite_carac}",fiche.Caracteristics.Dexterite);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colConstition_carac}",fiche.Caracteristics.Constitution);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colIntelligence_carac}",fiche.Caracteristics.Intelligence);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colSagesse_carac}", fiche.Caracteristics.Sagesse);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colCharisme_carac}", fiche.Caracteristics.Charisme);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colJds_force}", fiche.SaveRolls.ForceSave);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colJds_dexterite}",fiche.SaveRolls.DexteriteSave);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colJds_constitution}",fiche.SaveRolls.ConstitutionSave);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colJds_intelligence}",fiche.SaveRolls.IntelligenceSave);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colJds_sagesse}", fiche.SaveRolls.SagesseSave);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colJds_charisme}", fiche.SaveRolls.CharismeSave);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colInspiration}", fiche.Inspiration);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colClasse_armure}", fiche.Status.ClasseArmure);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colInitiative}", fiche.Status.Initiative);
                command.Parameters.AddWithValue($@"{IFicheColumnsName.colVitesse}", fiche.Status.Vitesse);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colPv_max}", fiche.HpManager.MaxHp);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colPv_actuel}", fiche.HpManager.CurrentHp);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colPv_temporaire}", fiche.HpManager.TemporaryHp);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colDes_de_vie}", fiche.HpManager.HpDice);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colSucces_jds_contre_mort}", fiche.DeathRolls.SuccessRoll);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colEchec_jds_contre_mort}",fiche.DeathRolls.FailRoll);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colMaitrises}", fiche.Masteries.Maitrises);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colLangues}", fiche.Masteries.Langues);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colPiece_cuivre}", fiche.Wallet.Cuivre);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colPiece_argent}", fiche.Wallet.Argent);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colPiece_or}", fiche.Wallet.Or);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colPiece_electrum}", fiche.Wallet.Electrum);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colPiece_platine}", fiche.Wallet.Platine);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colEquipement}", fiche.Equipement);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colCapacite_et_trait}", fiche.CapaciteEtTrait);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colTrait_de_personnalite}", fiche.BackgroundAndTrait.TraitDePersonnalite);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colIdeaux}", fiche.BackgroundAndTrait.Ideaux);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colLiens}", fiche.BackgroundAndTrait.Liens);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colDefauts}", fiche.BackgroundAndTrait.Defauts);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colAlignement}", fiche.BackgroundAndTrait.Alignement);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colHistorique}", fiche.BackgroundAndTrait.Historique);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colAge}", fiche.BackgroundAndTrait.Age);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colApparence}", fiche.BackgroundAndTrait.Apparence);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colAllie_et_organisation}", fiche.BackgroundAndTrait.AllieEtOrganisation);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colBackground}", fiche.BackgroundAndTrait.Background);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colClasse}", fiche.BasicInfo.Classe);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colNiveau}", fiche.BasicInfo.Niveau);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colRace}", fiche.BasicInfo.Race);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colNom_personnage}", fiche.BasicInfo.NomPersonnage);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colExperience}", fiche.BasicInfo.Experience);
                command.Parameters.AddWithValue($"@{IFicheColumnsName.colNote_joueur}",fiche.Note);
        }
    }
}