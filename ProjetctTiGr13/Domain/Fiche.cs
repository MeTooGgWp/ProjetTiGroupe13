using ProjetctTiGr13.Domain.FicheComponent;

namespace ProjetctTiGr13.Domain
{
    public class Fiche
    {
        public int IdFiche { get; set; }
        public string IdJoueur { get; set; }
        public string Equipement { get; set; }
        public string CapaciteEtTrait { get; set; }
        public string Note { get; set; }
        
        //Composant de la fiche 
        private BasicCharacterInfo BasicInfo;
        private HealthPointManager HpManager;
        private SaveRollManager SaveRolls;
        private DeathRollManager DeathRolls;
        private MoneyManager Wallet;
        private PersonalityAndBackground BackgroundAndTrait;
        private CharacterMasteries Masteries;
        private CaracteristicManager Caracteristics;
        private CharacterStatus Status;


        public Fiche()
        {
            BasicInfo = new BasicCharacterInfo();
            HpManager = new HealthPointManager();
            SaveRolls = new SaveRollManager();
            DeathRolls = new DeathRollManager();
            Wallet = new MoneyManager();
            BackgroundAndTrait = new PersonalityAndBackground();
            Masteries = new CharacterMasteries();
            Caracteristics = new CaracteristicManager();
            Status = new CharacterStatus();
        }




    }
}