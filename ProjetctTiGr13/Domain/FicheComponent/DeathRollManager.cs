namespace ProjetctTiGr13.Domain.FicheComponent
{
    public class DeathRollManager
    {
        public int SuccessRoll { get; set; }
        public int FailRoll { get; set; }

        public DeathRollManager()
        {
            SuccessRoll = 0;
            FailRoll = 0;
        }
    }
}