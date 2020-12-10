using System.ComponentModel.DataAnnotations;

namespace ProjetctTiGr13.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string Pseudo { get; set; }

        [Required]
        public string Password { get; set; }
    }
}