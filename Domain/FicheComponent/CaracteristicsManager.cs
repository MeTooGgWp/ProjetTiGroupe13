namespace ProjetctTiGr13.Domain.FicheComponent
{
    public class CaracteristicsManager
    {
        public int Force { get; set;}
        public int Dexterite { get; set;}
        public int Constitution { get; set;}
        public int Intelligence { get; set;}
        public int Sagesse { get; set;}
        public int Charisme { get; set;}

        public CaracteristicsManager()
        {
            Force = 0;
            Dexterite = 0;
            Constitution = 0;
            Intelligence = 0;
            Sagesse = 0;
            Charisme = 0;
        }
        
    }
}