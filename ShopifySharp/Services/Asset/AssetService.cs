using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Utilities;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify's Assets API.
/// </summary>
public class AssetService : ShopifyService, IAssetService
{
    /// <summary>
    /// Creates a new instance of <see cref="AssetService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public AssetService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    internal AssetService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<Asset> GetAsync(long themeId, string key, string fields = null, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"themes/{themeId}/assets.json");
        // Add the proper asset querystring
        req = SetAssetQuerystring(req, key, themeId);

        if (string.IsNullOrEmpty(fields) == false)
        {
            req.QueryParams.Add("fields", fields);
        }

        var response = await ExecuteRequestAsync<Asset>(req, HttpMethod.Get, cancellationToken, rootElement: "asset");
            
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<IEnumerable<Asset>> ListAsync(long themeId, AssetListFilter filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<IEnumerable<Asset>>($"themes/{themeId}/assets.json", "assets", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Asset> CreateOrUpdateAsync(long themeId, Asset asset, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"themes/{themeId}/assets.json");
        var content = new JsonContent(new
        {
            asset = asset
        });

        var response = await ExecuteRequestAsync<Asset>(req, HttpMethod.Put, cancellationToken, content, "asset");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long themeId, string key, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"themes/{themeId}/assets.json");

        req = SetAssetQuerystring(req, key, themeId);

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }

    /// <summary>
    /// Sets the proper querystring for getting or deleting a single asset.
    /// </summary>
    /// <param name="req">The request to modify.</param>
    /// <param name="key">The key value of the asset, e.g. 'templates/index.liquid' or 'assets/bg-body.gif'.</param>
    /// <param name="themeId">The id of the theme that the asset belongs to.</param>
    /// <returns>The request with the proper querystring.</returns>
    protected virtual RequestUri SetAssetQuerystring(RequestUri req, string key, long themeId)
    {
        //QS should look like:
        //?asset[key]={key}&theme_id={themeId}
        req.QueryParams.Add("asset[key]", key);
        req.QueryParams.Add("theme_id", themeId);

        return req;
    }
}