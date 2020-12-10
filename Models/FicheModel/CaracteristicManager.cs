#nullable disable

namespace Models.FicheModel
{
    public partial class CaracteristicManager
    {
        public int IdFiche { get; set; }
        public byte Force { get; set; }
        public byte Dexterite { get; set; }
        public byte Constitution { get; set; }
        public byte Intelligence { get; set; }
        public byte Sagesse { get; set; }
        public byte Charisme { get; set; }

        public virtual Fiche IdFicheNavigation { get; set; }
    }
}
