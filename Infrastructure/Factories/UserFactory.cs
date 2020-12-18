﻿using System.Data.SqlClient;
using Infrastructure.User;

namespace Infrastructure.Factories
{
    public class UserFactory : IInstanceFromReaderFactory<Entities.User>
    {
        public Entities.User CreateFromReader(SqlDataReader reader)
        {
            return new Entities.User
            {
                pseudo = reader.GetString(reader.GetOrdinal(UserSqlServer.ColPseudo)),
                mail = reader.GetString(reader.GetOrdinal(UserSqlServer.ColIdentifiant)),
                Password = reader.GetString(reader.GetOrdinal(UserSqlServer.ColMdp)),
            };

        }
    }
}