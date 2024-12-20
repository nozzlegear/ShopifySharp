using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating mapping between Shopify products and collections.
/// </summary>
public class CollectService : ShopifyService, ICollectService
{
    /// <summary>
    /// Creates a new instance of <see cref="CustomerService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public CollectService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal CollectService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal CollectService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<int> CountAsync(CollectCountFilter filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<int>("collects/count.json", "count", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Collect>> ListAsync(ListFilter<Collect> filter, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync("collects.json", "collects", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Collect>> ListAsync(CollectListFilter filter = null, CancellationToken cancellationToken = default) =>
        await ListAsync(filter?.AsListFilter(), cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Collect> GetAsync(long collectId, string fields = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<Collect>($"collects/{collectId}.json", "collect", fields, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Collect> CreateAsync(Collect collect, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri("collects.json");
        var content = new JsonContent(new
        {
            collect = collect
        });

        var response = await ExecuteRequestAsync<Collect>(req, HttpMethod.Post, cancellationToken, content, "collect");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long collectId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"collects/{collectId}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }
}