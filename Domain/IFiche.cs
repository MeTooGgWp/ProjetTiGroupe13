using ProjetctTiGr13.Domain.FicheComponent;

namespace ProjetctTiGr13.Domain
{
    public interface IFiche
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
    }
}