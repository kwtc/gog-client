using Newtonsoft.Json;

namespace Kwtc.Gog.Client.Models.List;

public class GogModel
{
    [JsonProperty("body")]
    public Body? Body { get; set; }
}