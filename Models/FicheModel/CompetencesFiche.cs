#nullable disable

namespace Models.FicheModel
{
    public partial class CompetencesFiche
    {
        public int IdComp { get; set; }
        public int IdFiche { get; set; }

        public virtual Competence IdCompNavigation { get; set; }
        public virtual Fiche IdFicheNavigation { get; set; }
    }
}
