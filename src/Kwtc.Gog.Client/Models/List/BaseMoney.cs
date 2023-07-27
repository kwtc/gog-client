using Newtonsoft.Json;

namespace Kwtc.Gog.Client.Models.List;

public class BaseMoney
{
    [JsonProperty("amount")]
    public string? Amount { get; set; }

    [JsonProperty("currency")]
    public string? Currency { get; set; }
}