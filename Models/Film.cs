
using System.Text.Json.Serialization;

namespace MyApp.Models
{
    public class Film
    {
        [JsonIgnore]
        public int Id { get; set; }
        
        [JsonPropertyName("film_name")]
        public string? Title { get; set; }

        [JsonPropertyName("director_name")]
        public string? Director { get; set; }
    }
}
