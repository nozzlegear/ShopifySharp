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
/// A service for manipulating Shopify Product which is available to your sales channel
/// </summary>
public class ProductListingService: ShopifyService, IProductListingService
{
    /// <summary>
    /// Creates a new instance of <see cref="ProductListingService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public ProductListingService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal ProductListingService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal ProductListingService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<ListResult<ProductListing>> ListAsync(ListFilter<ProductListing> filter, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync("product_listings.json", "product_listings", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<ProductListing>> ListAsync(ProductListingListFilter filter = null, CancellationToken cancellationToken = default) =>
        await ListAsync(filter?.AsListFilter(), cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ProductListing> GetAsync(long productId, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<ProductListing>($"product_listings/{productId}.json", "product_listing", cancellationToken: cancellationToken);

    /// <inheritdoc />
    public virtual async Task<int> CountAsync(CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<int>("product_listings/count.json", "count", cancellationToken: cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<long>> ListIdsAsync(CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync("product_listings/product_ids.json", "product_ids", ListFilter<long>.Empty, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ProductListing> CreateAsync(long productId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"product_listings/{productId}.json");
        var content = new JsonContent(new
        {
            product_listing = new { product_id = productId }
        });
        var response = await ExecuteRequestAsync<ProductListing>(req, HttpMethod.Put, cancellationToken, content, "product_listing");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long productId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"product_listings/{productId}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }
}