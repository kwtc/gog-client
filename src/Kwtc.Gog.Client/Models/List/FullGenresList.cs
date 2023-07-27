using Newtonsoft.Json;

namespace Kwtc.Gog.Client.Models.List;

public class FullGenresList
{
    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("slug")]
    public string? Slug { get; set; }

    [JsonProperty("level")]
    public int Level { get; set; }
}