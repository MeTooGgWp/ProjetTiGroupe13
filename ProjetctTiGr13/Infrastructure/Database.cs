using System.Data.SqlClient;

namespace ProjetctTiGr13.Infrastructure
{
    public class Database
    {
        private static readonly string ConnectionString =
            "Server=db-fiche-perso.database.windows.net,1433;Database=db_fiche_perso;User Id=louispoulet;Password=ProjetGroupe13";
        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}