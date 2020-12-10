namespace ProjetctTiGr13.Domain.FicheComponent
{
    public class CharacterStatus
    {
        public int ClasseArmure { get; set; }
        public int Initiative { get; set; }
        public float Vitesse { get; set; }

        public CharacterStatus()
        {
            ClasseArmure = 0;
            Initiative = 0;
            Vitesse = 0;
        }
    }
}