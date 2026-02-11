using System;
using ShopifySharp.Filters;
using ShopifySharp.Lists;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify's Location API.
/// </summary>
public class LocationService : ShopifyService, ILocationService
{
    /// <summary>
    /// Creates a new instance of <see cref="LocationService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public LocationService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal LocationService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    internal LocationService(ShopifyApiCredentials shopifyApiCredentials, IServiceProvider serviceProvider) : base(shopifyApiCredentials, serviceProvider) {}
    #nullable restore
    internal LocationService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    public virtual async Task<Location> GetAsync(long id, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<Location>($"locations/{id}.json", "location", cancellationToken: cancellationToken);

    public virtual async Task<ListResult<Location>> ListAsync(ListFilter<Location> filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync("locations.json", "locations", filter, cancellationToken);

    public virtual async Task<ListResult<Location>> ListAsync(LocationListFilter filter, CancellationToken cancellationToken = default) =>
        await ListAsync(filter?.AsListFilter(), cancellationToken);
}