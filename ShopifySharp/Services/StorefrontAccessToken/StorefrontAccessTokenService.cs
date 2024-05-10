using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;

namespace ShopifySharp;

/// <summary>
/// A service for working with Shopify's StorefrontAccessTokens API.
/// </summary>
public class StorefrontAccessTokenService : ShopifyService, IStorefrontAccessTokenService
{
    public StorefrontAccessTokenService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    internal StorefrontAccessTokenService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public async Task<StorefrontAccessToken> CreateAsync(string title, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri("storefront_access_tokens.json");
        var content = new JsonContent(new
        {
            storefront_access_token = new
            {
                title = title 
            }
        });
        var response = await ExecuteRequestAsync<StorefrontAccessToken>(req, HttpMethod.Post, cancellationToken, content, "storefront_access_token");

        return response.Result;
    }

    /// <inheritdoc />
    public async Task DeleteAsync(long id, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"storefront_access_tokens/{id}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }

    /// <inheritdoc />
    public async Task<IEnumerable<StorefrontAccessToken>> ListAsync(CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri("storefront_access_tokens.json");
        var response = await ExecuteRequestAsync<IEnumerable<StorefrontAccessToken>>(req, HttpMethod.Get, cancellationToken, rootElement: "storefront_access_tokens");

        return response.Result;
    }
}