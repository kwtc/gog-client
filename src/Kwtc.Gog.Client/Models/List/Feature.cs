using Newtonsoft.Json;

namespace Kwtc.Gog.Client.Models.List;

public class Feature
{
    [JsonProperty("slug")]
    public string? Slug { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }
}