using Entities;

namespace Models
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