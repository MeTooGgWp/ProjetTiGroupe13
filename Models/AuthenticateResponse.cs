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

        public override bool Equals(object? obj)
        {
            var other = (AuthenticateResponse) obj;
            return this.Pseudo == other.Pseudo && this.Token == other.Token;
        }
    }
}