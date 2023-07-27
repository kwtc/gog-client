using System.Collections.Generic;

namespace Kwtc.Gog.Client.Models.Search;

public class ProductModel
{
    public string? Developer { get; set; }

    public string? Publisher { get; set; }

    public IEnumerable<string>? Gallery { get; set; }

    public VideoModel? Video { get; set; }

    public IEnumerable<string>? SupportedOperatingSystems { get; set; }

    public IEnumerable<string>? Genres { get; set; }

    public string? GlobalReleaseDate { get; set; }

    public bool? IsTBA { get; set; }

    public PriceModel? Price { get; set; }

    public bool? IsDiscounted { get; set; }

    public bool? IsInDevelopment { get; set; }

    public int? Id { get; set; }

    public string? ReleaseDate { get; set; }

    public AvailabilityModel? Availability { get; set; }

    public SalesVisibilityModel? SalesVisibility { get; set; }

    public bool? Buyable { get; set; }

    public string? Title { get; set; }

    public string? Image { get; set; }

    public string? Url { get; set; }

    public string? SupportUrl { get; set; }

    public string? ForumUrl { get; set; }

    //public IEnumerable<IEnumerable<string>>? WorksOn { get; set; }
    public string? Category { get; set; }

    public string? OriginalCategory { get; set; }

    public int? Rating { get; set; }

    public int? Type { get; set; }

    public bool? IsComingSoon { get; set; }

    public bool? IsPriceVisible { get; set; }

    public bool? IsMovie { get; set; }

    public bool? IsGame { get; set; }

    public string? Slug { get; set; }

    public bool? IsWishlistable { get; set; }
}
