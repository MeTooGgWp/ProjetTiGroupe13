using System.Collections.Generic;
using System.Data;

namespace ProjetctTiGr13.Infrastructure.User
{
    public class UserRepository : IUserReposory
    {
        
        private IInstanceFromReaderFactory<Entities.User> _userFactory = new UserFactory();
        
        public IEnumerable<Entities.User> Query()
        {
            
            IList<Entities.User> users = new List<Entities.User>();
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = UserSqlServer.ReqQuery;

                var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (reader.Read())
                {
                    users.Add(_userFactory.CreateFromReader(reader));
                }
            }

            return users;
        }

        public Entities.User GetByPseudo(string pseudo)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();

                cmd.CommandText = UserSqlServer.ReqGetByPseudo;
                cmd.Parameters.AddWithValue($"@{UserSqlServer.ColPseudo}",pseudo);

                var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (reader.Read())
                {
                    return _userFactory.CreateFromReader(reader);
                }
            }

            return null;
        }

        public Entities.User Create(Entities.User user)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = UserSqlServer.ReqCreate;

                cmd.Parameters.AddWithValue($"@{UserSqlServer.ColPseudo}", user.pseudo);
                cmd.Parameters.AddWithValue($"@{UserSqlServer.ColIdentifiant}", user.mail);
                cmd.Parameters.AddWithValue($"@{UserSqlServer.ColMdp}", user.Password);
                
            }

            return user;
        }

        public bool Update(Entities.User user)
        {
            using (var connection = Database.GetConnection())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = UserSqlServer.ReqUpdate;

                cmd.Parameters.AddWithValue($"@{UserSqlServer.ColPseudo}", user.pseudo);
                cmd.Parameters.AddWithValue($"@{UserSqlServer.ColIdentifiant}", user.mail);
                cmd.Parameters.AddWithValue($"@{UserSqlServer.ColMdp}", user.Password);
                
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}