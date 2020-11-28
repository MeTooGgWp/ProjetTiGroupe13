using ProjetctTiGr13.Domain.FicheComponent;

namespace ProjetctTiGr13.Domain
{
    public class Fiche : IFiche
    {
        public int IdFiche { get; set; }
        public string IdJoueur { get; set; }
        public string Equipement { get; set; }
        public string CapaciteEtTrait { get; set; }
        public string Note { get; set; }
        public bool Inspiration { get; set; }
        
        //Composant de la fiche 
        public BasicCharacterInfo BasicInfo { get; set; }
        public HealthPointManager HpManager { get; set; }
        public SaveRollManager SaveRolls { get; set; }
        public DeathRollManager DeathRolls { get; set; }
        public MoneyManager Wallet { get; set; }
        public PersonalityAndBackground BackgroundAndTrait { get; set; }
        public CharacterMasteries Masteries { get; set; }
        public CaracteristicManager Caracteristics { get; set; }
        public CharacterStatus Status { get; set; }


        public Fiche()
        {
            IdJoueur = "";
            Equipement = "";
            CapaciteEtTrait = "";
            Note = "";
            
            
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