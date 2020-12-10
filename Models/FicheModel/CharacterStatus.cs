#nullable disable

namespace Models.FicheModel
{
    public partial class CharacterStatus
    {
        public int IdFiche { get; set; }
        public byte ClasseArmure { get; set; }
        public byte Initiative { get; set; }
        public byte Vitesse { get; set; }

        public virtual Fiche IdFicheNavigation { get; set; }
    }
}
