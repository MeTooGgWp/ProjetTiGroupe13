namespace ProjetctTiGr13.Domain.FicheComponent
{
    public class MoneyManager
    {
        public int Cuivre { get; set;}
        public int Argent { get; set;}
        public int Or { get; set;}
        public int Platine { get; set;}
        public int Electrum { get; set;}


        public MoneyManager()
        {
            Cuivre = 0;
            Argent = 0;
            Or = 0;
            Platine = 0;
            Electrum = 0;
        }

        public MoneyManager(int c, int a, int o, int p, int e)
        {
            Cuivre = c;
            Argent = a;
            Or = o;
            Platine = p;
            Electrum = e;
        }
    }
}