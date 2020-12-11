namespace ProjetctTiGr13.Domain.FicheComponent
{
    public class BasicCharacterInfo
    {
        public string Classe { get; set; }
        public byte Niveau { get; set; }
        public string Race { get; set; }
        public string NomPersonnage { get; set; }
        public int Experience { get; set;}

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