

using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string Pseudo { get; set; }

        [Required]
        public string Password { get; set; }
    }
}