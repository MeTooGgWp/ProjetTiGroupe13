#nullable disable

namespace Models.FicheModel
{
    public partial class DeathrollManager
    {
        public int IdFiche { get; set; }
        public byte SuccesJdsContreMort { get; set; }
        public byte EchecJdsContreMort { get; set; }

        public virtual Fiche IdFicheNavigation { get; set; }
    }
}
