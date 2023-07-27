using Newtonsoft.Json;

namespace Kwtc.Gog.Client.Models.List;

public class Price
{
    [JsonProperty("final")]
    public string? Final { get; set; }

    [JsonProperty("base")]
    public string? Base { get; set; }

    [JsonProperty("discount")]
    public string? Discount { get; set; }

    [JsonProperty("finalMoney")]
    public FinalMoney? FinalMoney { get; set; }

    [JsonProperty("baseMoney")]
    public BaseMoney? BaseMoney { get; set; }
}