using System.Collections;
using System.Collections.Generic;

namespace ProjetctTiGr13.Infrastructure.User
{
    public interface IUserReposory
    {
        public IEnumerable<Entities.User> Query();
       // public Entities.User GetByPseudo(string pseudo);
        public Entities.User Create(Entities.User u);
        public bool Update(Entities.User user);
    }
}