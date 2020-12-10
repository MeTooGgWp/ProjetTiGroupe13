#nullable disable

namespace Models.FicheModel
{
    public partial class CharacterMastery
    {
        public int IdFiche { get; set; }
        public string Maitrises { get; set; }
        public string Langues { get; set; }

        public virtual Fiche IdFicheNavigation { get; set; }
    }
}
