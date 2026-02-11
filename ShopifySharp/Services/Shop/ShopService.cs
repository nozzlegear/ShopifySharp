using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

public class ShopService: ShopifyService, IShopService
{
    /// <summary>
    /// Creates a new instance of <see cref="ShopService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public ShopService(string myShopifyUrl, string shopAccessToken): base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal ShopService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    internal ShopService(ShopifyApiCredentials shopifyApiCredentials, IServiceProvider serviceProvider) : base(shopifyApiCredentials, serviceProvider) {}
    #nullable restore
    internal ShopService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
         
    /// <inheritdoc />
    public virtual async Task<Shop> GetAsync(CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<Shop>("shop.json", "shop", cancellationToken: cancellationToken);

    /// <inheritdoc />
    public virtual async Task UninstallAppAsync(CancellationToken cancellationToken = default)
    {
        var request = BuildRequestUri("api_permissions/current.json");

        await ExecuteRequestAsync(request, HttpMethod.Delete, cancellationToken: cancellationToken);
    }
}