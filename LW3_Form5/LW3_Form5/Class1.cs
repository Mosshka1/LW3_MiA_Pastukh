using Newtonsoft.Json;

namespace LW3_Form5
{
    public class Film
    {
        [JsonProperty("id")] public string Id { get; set; } = "";
        [JsonProperty("title")] public string Title { get; set; } = "";
        [JsonProperty("original_title")] public string OriginalTitle { get; set; } = "";
        [JsonProperty("director")] public string Director { get; set; } = "";
        [JsonProperty("release_date")] public string ReleaseDate { get; set; } = "";
        [JsonProperty("description")] public string Description { get; set; } = "";
        [JsonProperty("url")] public string Url { get; set; } = "";
    }
}
