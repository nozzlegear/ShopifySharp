#nullable enable
using System;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading;
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
    /// <param name="cancellationToken">A cancellation token which can cancel the request.</param>
    /// <returns>Returns true if the shop domain is a Shopify store.</returns>
    Task<bool> IsValidShopDomainAsync(string shopDomain, CancellationToken cancellationToken = default);
}

public class ShopifyDomainUtility : IShopifyDomainUtility
{
    // TODO: use DI to get an IHttpClient from the constructor here
    private readonly IHttpClientFactory _httpClientFactory = new InternalHttpClientFactory();
    private readonly Version? _assemblyVersion = typeof(IShopifyDomainUtility).GetTypeInfo().Assembly.GetName().Version;
    private string UserAgent => $"ShopifySharp v{_assemblyVersion} (https://github.com/nozzlegear/shopifysharp)";

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
    public async Task<bool> IsValidShopDomainAsync(string shopDomain, CancellationToken cancellationToken = default)
    {
        var requestUri = BuildShopDomainUri(shopDomain);
        var client = _httpClientFactory.CreateClient();
        using var msg = new HttpRequestMessage(HttpMethod.Head, requestUri);
        msg.Headers.Add("User-Agent", UserAgent);

        try
        {
            var response = await client.SendAsync(msg, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
            var hasShopIdHeader = response.Headers.Any(h => h.Key.Equals("X-ShopId", StringComparison.OrdinalIgnoreCase));

            return hasShopIdHeader;
        }
        catch (HttpRequestException)
        {
            return false;
        }
    }
}
