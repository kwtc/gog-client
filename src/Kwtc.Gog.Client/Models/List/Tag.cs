using Newtonsoft.Json;

namespace Kwtc.Gog.Client.Models.List;

public class Tag
{
    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("slug")]
    public string? Slug { get; set; }
}