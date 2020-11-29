using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ProjetctTiGr13.Entities;
using ProjetctTiGr13.Helpers;
using ProjetctTiGr13.Infrastructure.User;
using ProjetctTiGr13.Models;

namespace ProjetctTiGr13.Services
{
     public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();

        public UserRepository GetRepository();
        
        User GetByPseudo(string pseudo);
    }

    public class UserService : IUserService
    {

        private UserRepository Repository;
         
        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        private List<User> _users = new List<User>
        {
            new User { pseudo = "test", mail = "test@gmail.com", Password = "test" }
        };

        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            Repository = new UserRepository();
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = Repository.GetByPseudo(model.Pseudo);
              // return null if user not found
            if (user == null) return null;
            if (user.Password == model.Password);

          

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        public IEnumerable<User> GetAll()
        {
            return Repository.Query().Cast<User>();
        }

        public User GetByPseudo(string pseudo)
        {
            return _users.FirstOrDefault(x => x.pseudo == pseudo);
        }

        // helper methods

        private string generateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("pseudo", user.pseudo) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public UserRepository GetRepository()
        {
            return Repository;
        }
    }
}