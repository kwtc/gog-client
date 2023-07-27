using System.Collections.Generic;

namespace Kwtc.Gog.Client.Models.Search;

public class GogResultModel
{
    public IEnumerable<ProductModel> Products { get; set; } = default!;
}
