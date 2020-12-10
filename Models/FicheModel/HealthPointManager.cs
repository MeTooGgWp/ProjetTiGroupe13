#nullable disable

namespace Models.FicheModel
{
    public partial class HealthPointManager
    {
        public int IdFiche { get; set; }
        public short PvMax { get; set; }
        public short PvActuel { get; set; }
        public short PvTemporaire { get; set; }
        public byte DesDeVie { get; set; }

        public virtual Fiche IdFicheNavigation { get; set; }
    }
}
