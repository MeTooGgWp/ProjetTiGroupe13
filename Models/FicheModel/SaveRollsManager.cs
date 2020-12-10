#nullable disable

namespace Models.FicheModel
{
    public partial class SaveRollsManager
    {
        public int IdFiche { get; set; }
        public bool JdsForce { get; set; }
        public bool JdsDexterite { get; set; }
        public bool JdsConstitution { get; set; }
        public bool JdsIntelligence { get; set; }
        public bool JdsSagesse { get; set; }
        public bool JdsCharisme { get; set; }

        public virtual Fiche IdFicheNavigation { get; set; }
    }
}
