using System.Collections.Generic;
using Newtonsoft.Json;

namespace Kwtc.Gog.Client.Models.List;

public class Product
{
    [JsonProperty("id")]
    public string? Id { get; set; }

    [JsonProperty("slug")]
    public string? Slug { get; set; }

    [JsonProperty("features")]
    public IList<Feature>? Features { get; set; }

    [JsonProperty("screenshots")]
    public IList<string>? Screenshots { get; set; }

    [JsonProperty("userPreferredLanguage")]
    public UserPreferredLanguage? UserPreferredLanguage { get; set; }

    [JsonProperty("releaseDate")]
    public string? ReleaseDate { get; set; }

    [JsonProperty("productType")]
    public string? ProductType { get; set; }

    [JsonProperty("title")]
    public string? Title { get; set; }

    [JsonProperty("coverHorizontal")]
    public string? CoverHorizontal { get; set; }

    [JsonProperty("coverVertical")]
    public string? CoverVertical { get; set; }

    [JsonProperty("developers")]
    public IList<string>? Developers { get; set; }

    [JsonProperty("publishers")]
    public IList<string>? Publishers { get; set; }

    [JsonProperty("operatingSystems")]
    public IList<string>? OperatingSystems { get; set; }

    [JsonProperty("price")]
    public Price? Price { get; set; }

    [JsonProperty("productState")]
    public string? ProductState { get; set; }

    [JsonProperty("genres")]
    public IList<Genre>? Genres { get; set; }

    [JsonProperty("tags")]
    public IList<Tag>? Tags { get; set; }

    [JsonProperty("reviewsRating")]
    public int ReviewsRating { get; set; }
}
