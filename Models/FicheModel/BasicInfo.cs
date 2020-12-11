using Newtonsoft.Json;

#nullable disable

namespace Models.FicheModel
{
    public partial class BasicInfo
    {
        public int IdFiche { get; set; }
        public string Classe { get; set; }
        public byte Niveau { get; set; }
        public string Race { get; set; }
        public string NomPersonnage { get; set; }
        public int Experience { get; set; }


        /*public BasicInfo()
        {
            Classe = "";
        }*/
        
        public virtual Fiche IdFicheNavigation { get; set; }
        
    }
}
