using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Kwtc.Gog.Client.Models.List;
using Kwtc.Gog.Client.Models.Search;
using Newtonsoft.Json;

namespace Kwtc.Gog.Client;

public class GogClient : IGogClient
{
    private const string ApiUrl = "https://api.gog.com";
    private const string StoreUrl = "https://www.gog.com";

    public async Task<GogResultModel> SearchProductsByTitle(string title, int limit = 20, CancellationToken cancellationToken = default)
    {
        try
        {
            return await StoreUrl
                         .AppendPathSegments("games", "ajax", "filtered")
                         .SetQueryParams(
                             new
                             {
                                 limit,
                                 mediaType = "game",
                                 search = title
                             })
                         .GetJsonAsync<GogResultModel>(cancellationToken);
        }
        catch (Exception)
        {
            // ignored
        }

        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Product>> GetAllProducts(CancellationToken cancellationToken = default)
    {
        var products = new ConcurrentBag<Product>();
        var initialModel = await GetProductsByPage(1, cancellationToken);
        if (initialModel?.Body?.Products == null)
        {
            throw new InvalidOperationException("Unable to get Gog products model");
        }

        foreach (var product in initialModel.Body.Products)
        {
            products.Add(product);
        }

        var tasks = Enumerable
                    .Range(2, initialModel.Body.Pages)
                    .Select(async i =>
                    {
                        var model = await GetProductsByPage(i, cancellationToken);
                        if (model?.Body?.Products == null)
                        {
                            throw new InvalidOperationException("Unable to get Gog products");
                        }

                        foreach (var product in model.Body.Products)
                        {
                            products.Add(product);
                        }
                    });
        await Task.WhenAll(tasks);

        return products;
    }

    private static async Task<GogModel?> GetProductsByPage(int pageNumber, CancellationToken cancellationToken)
    {
        // page 1: https://www.gog.com/en/games?order=asc:title
        // page 2: https://www.gog.com/en/games?order=asc:title&page=2

        var request = StoreUrl
            .AppendPathSegments("en", "games");

        if (pageNumber == 1)
        {
            request.SetQueryParams(
                new
                {
                    order = "asc:title"
                });
        }
        else
        {
            request.SetQueryParams(
                new
                {
                    order = "asc:title",
                    page = pageNumber.ToString()
                });
        }

        var result = await request.GetStringAsync(cancellationToken: cancellationToken);
        if (result == null)
        {
            throw new InvalidOperationException("Result is invalid");
        }

        // get relevant string
        var startIndex = result.IndexOf("&q;body&q;:{");
        var endIndex = result.IndexOf("}},&q;consulConfig&q;");
        var resultString = result.Substring(startIndex, endIndex - startIndex).Replace("&q;", "\"");

        GogModel? resultObject;
        try
        {
            resultObject = JsonConvert.DeserializeObject<GogModel>("{" + resultString + "}}");
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Unable to cast result to GogModel", ex);
        }

        return resultObject;
    }
}
