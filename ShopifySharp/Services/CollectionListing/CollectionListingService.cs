using ShopifySharp.Filters;
using ShopifySharp.Lists;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for interacting with Shopify product collection that a merchant has made available to your sales channel
/// </summary>
public class CollectionListingService: ShopifyService, ICollectionListingService
{
    /// <summary>
    /// Creates a new instance of <see cref="CollectionListingService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public CollectionListingService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal CollectionListingService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    #nullable restore
    internal CollectionListingService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    public virtual async Task<ListResult<CollectionListing>> ListAsync(ListFilter<CollectionListing> filter = default, CancellationToken cancellationToken = default) => 
        await ExecuteGetListAsync("collection_listings.json", "collection_listings", filter, cancellationToken);

    public virtual async Task<CollectionListing> GetAsync(long collectionId, CancellationToken cancellationToken = default) => 
        await ExecuteGetAsync<CollectionListing>($"collection_listings/{collectionId}.json", "collection_listing", cancellationToken: cancellationToken);

    public virtual async Task<ListResult<long>> ListIdsAsync(long collectionId, ListFilter<long> filter = default, CancellationToken cancellationToken = default) => 
        await ExecuteGetListAsync($"collection_listings/{collectionId}/product_ids.json", "product_ids", filter, cancellationToken);
}