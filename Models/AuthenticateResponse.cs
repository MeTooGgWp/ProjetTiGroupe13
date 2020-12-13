using Entities;

namespace Models
{
    public class AuthenticateResponse
    {
        public string Pseudo { get; set; }
        public string Token { get; set; }


        public AuthenticateResponse(User user, string token)
        {
            Pseudo = user.pseudo;
            Token = token;
        }
    }
}