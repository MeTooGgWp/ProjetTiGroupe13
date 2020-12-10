#nullable disable

namespace Models.FicheModel
{
    public partial class MoneyManager
    {
        public int IdFiche { get; set; }
        public short PieceCuivre { get; set; }
        public short PieceArgent { get; set; }
        public short PieceElectrum { get; set; }
        public short PieceOr { get; set; }
        public short PiecePlatine { get; set; }

        public virtual Fiche IdFicheNavigation { get; set; }
    }
}
