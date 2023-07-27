using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Kwtc.Gog.Client.Models.List;
using Kwtc.Gog.Client.Models.Search;

namespace Kwtc.Gog.Client;

public interface IGogClient
{
    Task<GogResultModel> SearchProductsByTitle(string title, int limit = 20, CancellationToken cancellationToken = default);

    /// <summary>
    /// Product ids are retrieved by scraping each store page
    /// </summary>
    Task<IEnumerable<Product>> GetAllProducts(CancellationToken cancellationToken = default);
}
