namespace ProjetctTiGr13.Domain.FicheComponent
{
    public class BasicCharacterInfo
    {
        public string Classe { get; set; }
        public int Niveau { get; set; }
        public string Race { get; set; }
        public string NomPersonnage { get; set; }
        public long Experience { get; set;}

        public BasicCharacterInfo()
        {
            Classe = "";
            Niveau = 0;
            Race = "";
            NomPersonnage = "";
            Experience = 0;
        }
    }
}