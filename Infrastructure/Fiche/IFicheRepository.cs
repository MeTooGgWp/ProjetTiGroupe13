using System.Collections.Generic;
using ProjetctTiGr13.Domain;

namespace Infrastructure.Fiche
{
    public interface IFicheRepository
    {
        IEnumerable<IFiche> QueryAll(); //Retourne toutes les fiches de la bd (à prioris ceci ne devrait JAMAIS servir à l'utilisateur)
        IEnumerable<IFiche> QueryByPlayer(string id_joueur); //Retourne toutes les fiches d'un utilisateurs 
        IFiche Get(int id_fiche,string id_joueur);
        IFiche Create(IFiche fiche);
        bool Delete(int id_fiche);
        bool Update(int id_fiche, string id_joueur, IFiche fiche);
    }
}