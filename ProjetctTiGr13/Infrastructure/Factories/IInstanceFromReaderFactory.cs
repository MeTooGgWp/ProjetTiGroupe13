using ProjetctTiGr13.Domain;
using System.Data.SqlClient;

namespace ProjetctTiGr13.Infrastructure
{
    
    
    public interface IInstanceFromReaderFactory<out T>
    {
        //Permet de créer une fiche à partir d'une entrée de la bd
        T CreateFromReader(SqlDataReader reader);

    }
}