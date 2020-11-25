namespace ProjetctTiGr13.Domain.FicheComponent
{
    public class PersonalityAndBackground
    {
        public string TraitDePersonnalite { get; set; }
        public string Ideaux { get; set; }
        public string Liens { get; set; }
        public string Defauts { get; set; }
        public string Historique { get; set; }
        public int Age { get; set; }
        public string Apparence { get; set; }
        public string AllieEtOrganisation { get; set; }
        public string Background { get; set; }

        public PersonalityAndBackground()
        {
            TraitDePersonnalite = "";
            Ideaux = "";
            Liens = "";
            Defauts = "";
            Historique = "";
            Age = 0;
            Apparence = "";
            AllieEtOrganisation = "";
            Background = "";
        }
    }
}