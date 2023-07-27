using Newtonsoft.Json;

namespace Kwtc.Gog.Client.Models.List;

public class PriceRange
{
    [JsonProperty("min")]
    public int Min { get; set; }

    [JsonProperty("max")]
    public double Max { get; set; }

    [JsonProperty("currency")]
    public string? Currency { get; set; }

    [JsonProperty("decimalPlaces")]
    public int DecimalPlaces { get; set; }
}