using System.Text.Json.Serialization;

namespace DocInfo.Views
{
    public class DoctorView
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("speciality_id")]
        public int Speciality_id { get; set; }
    }
}
