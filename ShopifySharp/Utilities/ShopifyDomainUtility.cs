#nullable enable
using System;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Utilities;

public interface IShopifyDomainUtility
{
    /// <summary>
    /// Transforms the <paramref name="shopDomain" /> into a URI, forcing it to https and stripping any path.
    /// </summary>
    Uri BuildShopDomainUri(string shopDomain);

    /// <summary>
    /// <p>A convenience function that tries to ensure that a given URL is a valid Shopify domain. It does this by making a HEAD request to the given domain, and returns true if the response contains an X-ShopId header.</p>
    /// <p>**Warning**: a domain could fake the response header, which would cause this method to return true.</p>
    /// <p>**Warning**: this method of validation is not officially supported by Shopify and could break at any time.</p>
    /// </summary>
    /// <param name="shopDomain">The shop domain to check. This should be a *.myshopify.com domain.</param>
    /// <returns>A boolean indicating whether the URL is valid.</returns>
    Task<bool> IsValidShopDomainAsync(string shopDomain);
}

public class ShopifyDomainUtility(IHttpClientFactory? httpClientFactory = null) : IShopifyDomainUtility
{
    private readonly IHttpClientFactory _httpClientFactory = httpClientFactory ?? new InternalHttpClientFactory();

    /// <inheritdoc />
    public Uri BuildShopDomainUri(string shopDomain)
    {
        var builder = new UriBuilder(shopDomain)
        {
            Scheme = Uri.UriSchemeHttps,
            // SSL port
            Port = 443,
            Path = string.Empty,
            Fragment = string.Empty,
            Query = string.Empty
        };
        return builder.Uri;
    }

    /// <inheritdoc />
    public async Task<bool> IsValidShopDomainAsync(string shopDomain)
    {
        var uri = BuildShopDomainUri(shopDomain);

        // Use an HttpClientHandler that disallows redirects, as Shopify will auto-redirect requests to the home page or admin login URL
        using var handler = new HttpClientHandler();
        handler.AllowAutoRedirect = false;
        var client = _httpClientFactory.CreateClient();
        using var msg = new HttpRequestMessage(HttpMethod.Head, uri);
        var version = typeof(IShopifyDomainUtility).GetTypeInfo().Assembly.GetName().Version;
        msg.Headers.Add("User-Agent", $"ShopifySharp v{version} (https://github.com/nozzlegear/shopifysharp)");

        try
        {
            var response = await client.SendAsync(msg);
            return response.Headers.Any(h => h.Key.Equals("X-ShopId", StringComparison.OrdinalIgnoreCase));
        }
        catch (HttpRequestException)
        {
            return false;
        }
    }
}
