using System;
using ShopifySharp.Filters;
using ShopifySharp.Lists;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for interacting with Shopify Collections.
/// </summary>
public class CollectionService : ShopifyService, ICollectionService
{
    /// <summary>
    /// Creates a new instance of the service.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public CollectionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal CollectionService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    internal CollectionService(ShopifyApiCredentials shopifyApiCredentials, IServiceProvider serviceProvider) : base(shopifyApiCredentials, serviceProvider) {}
    #nullable restore
    internal CollectionService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<ListResult<Product>> ListProductsAsync(long collectionId, ListFilter<Product> filter, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync($"collections/{collectionId}/products.json", "products", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Product>> ListProductsAsync(long collectionId, CollectionProductsListFilter filter = null, CancellationToken cancellationToken = default) =>
        await ListProductsAsync(collectionId, filter?.AsListFilter(), cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Collection> GetAsync(long collectionId, string fields = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<Collection>($"collections/{collectionId}.json", "collection", fields, cancellationToken);
}