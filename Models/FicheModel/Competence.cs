using System.Collections.Generic;

#nullable disable

namespace Models.FicheModel
{
    public partial class Competence
    {
        public Competence()
        {
            CompetencesFiches = new HashSet<CompetencesFiche>();
        }

        public int IdComp { get; set; }
        public string NomComp { get; set; }

        public virtual ICollection<CompetencesFiche> CompetencesFiches { get; set; }
    }
}
