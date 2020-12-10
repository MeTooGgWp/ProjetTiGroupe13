using System.Collections.Generic;

#nullable disable

namespace Models.FicheModel
{
    public partial class Compte
    {
        public Compte()
        {
            Fiches = new HashSet<Fiche>();
        }

        public string Pseudo { get; set; }
        public string Identifiant { get; set; }
        public string Mdp { get; set; }

        public virtual ICollection<Fiche> Fiches { get; set; }
    }
}
