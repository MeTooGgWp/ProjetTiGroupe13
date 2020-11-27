using ProjetctTiGr13.Entities;

namespace ProjetctTiGr13.Models
{
    public class AuthenticateResponse
    {
        public string pseudo { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(User user, string token)
        {
            pseudo = user.pseudo;
            Token = token;
        }
    }
}