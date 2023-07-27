using Newtonsoft.Json;

namespace Kwtc.Gog.Client.Models.List;

public class UserPreferredLanguage
{
    [JsonProperty("code")]
    public string? Code { get; set; }

    [JsonProperty("inAudio")]
    public bool InAudio { get; set; }

    [JsonProperty("inText")]
    public bool InText { get; set; }
}