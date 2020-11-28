using ProjetctTiGr13.Domain;
using System.Data.SqlClient;

namespace ProjetctTiGr13.Infrastructure
{
    
    
    public interface IFicheFactory
    {
        //Permet de créer une fiche à partir d'une entrée de la bd
        IFiche CreateFromReader(SqlDataReader reader);

    }
}