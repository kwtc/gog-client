using System.Collections.Generic;
using Newtonsoft.Json;

namespace Kwtc.Gog.Client.Models.List;

public class Body
{
    [JsonProperty("pages")]
    public int Pages { get; set; }

    [JsonProperty("productCount")]
    public int ProductCount { get; set; }

    [JsonProperty("products")]
    public IList<Product>? Products { get; set; }

    [JsonProperty("filters")]
    public Filters? Filters { get; set; }
}
