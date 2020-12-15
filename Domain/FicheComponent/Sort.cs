namespace ProjetctTiGr13.Domain.FicheComponent
{
    public class Sort
    {
        public byte NiveauSort { get; set; }
        
        public string NomSort { get; set; }
        
        public string DescriptionSort { get; set; }


        public Sort()
        {
            NiveauSort = 0;
            NomSort = "";
            DescriptionSort = "";
        }
        
    }
}