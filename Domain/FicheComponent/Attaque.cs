namespace ProjetctTiGr13.Domain.FicheComponent
{
    public class Attaque
    {
        public string NomAttaque { get; set; }
        
        public byte BonusAuJet { get; set; }

        public string TypeDegat { get; set; }
        
        public byte BonusAuDegat { get; set; }
        
        public byte DeDegat { get; set; }



        public Attaque()
        {
            NomAttaque = "";
            BonusAuDegat = 0;
            BonusAuJet = 0;
            TypeDegat = "";
            DeDegat = 0;
        }
        
        

    }
}