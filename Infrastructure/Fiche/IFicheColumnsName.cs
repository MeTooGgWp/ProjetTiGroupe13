namespace Infrastructure.Fiche
{
    
    //Cette classe sert à "définir" les colonnes pour la bd
    public interface IFicheColumnsName
    {
        public static readonly string TableName = "fiche";
        
        //Colone fiche Bd (id et jointure)
        public static readonly string colId_fiche = "id_fiche";
        public static readonly string colId_joueur = "id_joueur";
        
        //Caracteristique : 
        public static readonly string colForce_carac = "force_carac";
        public static readonly string colDexterite_carac = "dexterite_carac";
        public static readonly string colConstition_carac = "constitution_carac";
        public static readonly string colIntelligence_carac = "intelligence_carac";
        public static readonly string colSagesse_carac = "sagesse_carac";
        public static readonly string colCharisme_carac = "charisme_carac";
        
        //JDS : 
        public static readonly string colJds_force = "jds_force";
        public static readonly string colJds_dexterite = "jds_dexterite";
        public static readonly string colJds_constitution = "jds_constitution";
        public static readonly string colJds_intelligence = "jds_intelligence";
        public static readonly string colJds_sagesse = "jds_sagesse";
        public static readonly string colJds_charisme = "jds_charisme";
        
        //inspiration
        public static readonly string colInspiration = "inspiration";
        
        public static readonly string colClasse_armure = "classe_armure";
        
        public static readonly string colInitiative = "initiative";

        public static readonly string colVitesse = "vitesse";
        
        //PV : 
        public static readonly string colPv_max = "pv_max";
        public static readonly string colPv_actuel = "pv_actuel";
        public static readonly string colPv_temporaire = "pv_temporaire";
        public static readonly string colDes_de_vie = "des_de_vie";
        
        //Jds vs mort :
        public static readonly string colSucces_jds_contre_mort = "succes_jds_contre_mort";
        public static readonly string colEchec_jds_contre_mort = "echec_jds_contre_mort";

        public static readonly string colMaitrises = "maitrises";
        
        public static readonly string colLangues = "langues";
        
        //Argent : 
        public static readonly string colPiece_cuivre = "piece_cuivre";
        public static readonly string colPiece_argent = "piece_argent";
        public static readonly string colPiece_or = "piece_or";
        public static readonly string colPiece_electrum = "piece_electrum";
        public static readonly string colPiece_platine = "piece_platine";

        public static readonly string colEquipement = "equipement";

        public static readonly string colCapacite_et_trait = "capacite_et_trait";

        public static readonly string colTrait_de_personnalite = "trait_de_personnalite";
        
        //Concerne le backGround du personnage 

        public static readonly string colIdeaux = "ideaux";
        public static readonly string colLiens = "liens";
        public static readonly string colDefauts = "defauts";
        public static readonly string colAlignement = "alignement";
        public static readonly string colHistorique = "historique";
        public static readonly string colAge = "age";
        public static readonly string colApparence = "apparence";
        public static readonly string colAllie_et_organisation = "allie_et_organisation";
        public static readonly string colBackground = "background";
        
        
        //Information du personnage : 

        public static readonly string colClasse = "classe";
        public static readonly string colNiveau = "niveau";
        public static readonly string colRace = "race";
        public static readonly string colNom_personnage = "nom_personnage";
        public static readonly string colExperience = "experience";

        public static readonly string colNote_joueur = "note_joueur";




    }
}