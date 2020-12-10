#nullable disable

namespace Models.FicheModel
{
    public partial class PersonalityAndBackground
    {
        public int IdFiche { get; set; }
        public string TraitDePersonnalite { get; set; }
        public string Ideaux { get; set; }
        public string Liens { get; set; }
        public string Defauts { get; set; }
        public byte Alignement { get; set; }
        public string Historique { get; set; }
        public short Age { get; set; }
        public string Apparence { get; set; }
        public string AllieEtOrganisation { get; set; }
        public string Background { get; set; }

        public virtual Fiche IdFicheNavigation { get; set; }
    }
}
