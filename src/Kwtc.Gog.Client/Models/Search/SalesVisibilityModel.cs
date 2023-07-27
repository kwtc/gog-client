namespace Kwtc.Gog.Client.Models.Search;

public class SalesVisibilityModel
{
    public bool? IsActive { get; set; }

    public DateModel? FromObject { get; set; }

    public DateModel? ToObject { get; set; }

    public string? To { get; set; }
}