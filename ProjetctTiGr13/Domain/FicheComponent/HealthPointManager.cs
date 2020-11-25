namespace ProjetctTiGr13.Domain.FicheComponent
{
    public class HealthPointManager
    {
        public int MaxHp { get; set; }
        public int CurrentHp { get; set; }
        public int TemporaryHp { get; set; }
        public int HpDice { get; set;}

        public HealthPointManager()
        {
            MaxHp = 0;
            CurrentHp = 0;
            TemporaryHp = 0;
            HpDice = 0;
        }
    }
}