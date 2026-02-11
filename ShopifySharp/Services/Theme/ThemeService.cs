using System;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify themes.
/// </summary>
public class ThemeService : ShopifyService, IThemeService
{
    /// <summary>
    /// Creates a new instance of <see cref="ThemeService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public ThemeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal ThemeService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    internal ThemeService(ShopifyApiCredentials shopifyApiCredentials, IServiceProvider serviceProvider) : base(shopifyApiCredentials, serviceProvider) {}
    #nullable restore
    internal ThemeService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<IEnumerable<Theme>> ListAsync(ThemeListFilter filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<IEnumerable<Theme>>("themes.json", "themes", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Theme> GetAsync(long themeId, string fields = null, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"themes/{themeId}.json");

        if (!string.IsNullOrEmpty(fields))
        {
            req.QueryParams.Add("fields", fields);
        }

        var response = await ExecuteRequestAsync<Theme>(req, HttpMethod.Get, cancellationToken, rootElement: "theme");

        return response.Result;
    }

    ///<inheritdoc />
    public virtual async Task<Theme> CreateAsync(Theme theme, CancellationToken cancellationToken = default) =>
        await _CreateAsync(theme, cancellationToken);

    ///<inheritdoc />
    public virtual async Task<Theme> CreateAsync(Theme theme, string sourceUrl, CancellationToken cancellationToken = default) =>
        await _CreateAsync(theme, cancellationToken, sourceUrl);

    ///<inheritdoc />
    public virtual async Task<Theme> UpdateAsync(long themeId, Theme theme, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"themes/{themeId}.json");
        var content = new JsonContent(new
        {
            theme = theme
        });
        var response = await ExecuteRequestAsync<Theme>(req, HttpMethod.Put, cancellationToken, content, "theme");

        return response.Result;
    }

    ///<inheritdoc />
    public virtual async Task DeleteAsync(long themeId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"themes/{themeId}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }

    private async Task<Theme> _CreateAsync(Theme theme, CancellationToken cancellationToken, string sourceUrl = null)
    {
        var req = BuildRequestUri("themes.json");
        var body = theme.ToDictionary();

        if (!string.IsNullOrEmpty(sourceUrl))
        {
            body.Add("src", sourceUrl);
        }

        var content = new JsonContent(new
        {
            theme = body
        });
        var response = await ExecuteRequestAsync<Theme>(req, HttpMethod.Post, cancellationToken, content, "theme");

        return response.Result;
    }
}