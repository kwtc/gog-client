namespace Kwtc.Gog.Client.Models.Search;

public class PriceModel
{
    public decimal? Amount { get; set; }

    public decimal? BaseAmount { get; set; }

    public decimal? FinalAmount { get; set; }

    public bool? IsDiscounted { get; set; }

    public int? DiscountPercentage { get; set; }

    public decimal? DiscountDifference { get; set; }

    public string? Symbol { get; set; }

    public bool? IsFree { get; set; }

    public int? Discount { get; set; }

    public bool? IsBonusStoreCreditIncluded { get; set; }

    public decimal? BonusStoreCreditAmount { get; set; }

    public string? PromoId { get; set; }
}