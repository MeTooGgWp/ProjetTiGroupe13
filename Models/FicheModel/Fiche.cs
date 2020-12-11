using System.Collections.Generic;
using ProjetctTiGr13.Domain;

#nullable disable

namespace Models.FicheModel
{
    public partial class Fiche
    {
        public Fiche()
        {
            Attaques = new HashSet<Attaque>();
            CompetencesFiches = new HashSet<CompetencesFiche>();
            Sorts = new HashSet<Sort>();

           // BasicInfo = new BasicInfo();
        }
        

        public int IdFiche { get; set; }
        public string IdJoueur { get; set; }
        public bool Inspiration { get; set; }
        public string Equipement { get; set; }
        public string CapaciteEtTrait { get; set; }
        public string NoteJoueur { get; set; }

        public virtual Compte IdJoueurNavigation { get; set; }
        public virtual BasicInfo BasicInfo { get; set; }
        public virtual CaracteristicManager CaracteristicManager { get; set; }
        public virtual CharacterMastery CharacterMastery { get; set; }
        public virtual CharacterStatus CharacterStatus { get; set; }
        public virtual DeathrollManager DeathrollManager { get; set; }
        public virtual HealthPointManager HealthPointManager { get; set; }
        public virtual MoneyManager MoneyManager { get; set; }
        public virtual PersonalityAndBackground PersonalityAndBackground { get; set; }
        public virtual SaveRollsManager SaveRollsManager { get; set; }
        public virtual ICollection<Attaque> Attaques { get; set; }
        public virtual ICollection<CompetencesFiche> CompetencesFiches { get; set; }
        public virtual ICollection<Sort> Sorts { get; set; }
        
        public string to_string(){
            return "" + IdFiche;
        }
        
        
    }
    
    
    
}
