using System.Collections.Generic;
using Newtonsoft.Json;

namespace Kwtc.Gog.Client.Models.List;

public class Filters
{
    [JsonProperty("releaseDateRange")]
    public ReleaseDateRange? ReleaseDateRange { get; set; }

    [JsonProperty("priceRange")]
    public PriceRange? PriceRange { get; set; }

    [JsonProperty("genres")]
    public IList<Genre>? Genres { get; set; }

    [JsonProperty("languages")]
    public IList<Language>? Languages { get; set; }

    [JsonProperty("systems")]
    public IList<System>? Systems { get; set; }

    [JsonProperty("tags")]
    public IList<Tag>? Tags { get; set; }

    [JsonProperty("discounted")]
    public bool Discounted { get; set; }

    [JsonProperty("features")]
    public IList<Feature>? Features { get; set; }

    [JsonProperty("releaseStatuses")]
    public IList<ReleaseStatus>? ReleaseStatuses { get; set; }

    [JsonProperty("types")]
    public IList<string>? Types { get; set; }

    [JsonProperty("fullGenresList")]
    public IList<FullGenresList>? FullGenresList { get; set; }

    [JsonProperty("fullTagsList")]
    public IList<FullTagsList>? FullTagsList { get; set; }
}
