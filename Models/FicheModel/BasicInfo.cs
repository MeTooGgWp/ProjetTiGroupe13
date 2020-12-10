#nullable disable

namespace Models.FicheModel
{
    public partial class BasicInfo
    {
        public int IdFiche { get; set; }
        public string Classe { get; set; }
        public byte Niveau { get; set; }
        public string Race { get; set; }
        public int NomPersonnage { get; set; }
        public int Experience { get; set; }

        public virtual Fiche IdFicheNavigation { get; set; }
    }
}
