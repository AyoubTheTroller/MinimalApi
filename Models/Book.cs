
using System.Text.Json.Serialization;
//using Newtonsoft.Json;

namespace MyApp.Models
{
    public class Book
    {
        [JsonIgnore]
        public int Id { get; set; }
        
        [JsonPropertyName("book_name")]
         //[JsonProperty("book_name", Order = 1)]
        public string? Title { get; set; }
        [JsonPropertyName("author_name")]
        //[JsonProperty("author_name", Order = 0)]
        public string? Author { get; set; }
    }
}
