#nullable disable

namespace Models.FicheModel
{
    public partial class Attaque
    {
        public int IdFiche { get; set; }
        public string NomAttaque { get; set; }
        public byte BonusAuJet { get; set; }
        public string TypeDegat { get; set; }
        public byte BonusAuDegat { get; set; }
        public byte DeDegat { get; set; }

        public virtual Fiche IdFicheNavigation { get; set; }
    }
}
