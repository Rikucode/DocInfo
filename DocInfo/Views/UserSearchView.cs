using System.Text.Json.Serialization;

namespace DocInfo.Views
{
    public class UserSearchView
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("login")]
        public string Login { get; set; }    
    }
}
