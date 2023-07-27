using Newtonsoft.Json;

namespace Kwtc.Gog.Client.Models.List;

public class ReleaseDateRange
{
    [JsonProperty("min")]
    public int Min { get; set; }

    [JsonProperty("max")]
    public int Max { get; set; }
}