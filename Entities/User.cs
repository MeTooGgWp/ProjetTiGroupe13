using System.Text.Json.Serialization;

namespace Entities
{
    public class User
    {
        public string pseudo { get; set; }
        public string mail { get; set; }
        
        public string Password { get; set; }
    }
}