using System.ComponentModel.DataAnnotations.Schema;
using Castle.Components.DictionaryAdapter;

#nullable disable

namespace Models.FicheModel
{
    public partial class Sort
    {
        //public int IdSort { get; set; }
        public int IdFiche { get; set; }
        public byte NiveauSort { get; set; }
        public string NomSort { get; set; }
        public string DescriptionSort { get; set; }

        public virtual Fiche IdFicheNavigation { get; set; }
    }
}
