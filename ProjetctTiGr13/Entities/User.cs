using System.Text.Json.Serialization;

namespace ProjetctTiGr13.Entities
{
    public class User
    {
        public string pseudo { get; set; }
        public string mail { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
    }
}