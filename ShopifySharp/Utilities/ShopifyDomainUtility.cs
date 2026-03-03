#nullable enable
using System;
using System.Collections.Generic;
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
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly Version? _assemblyVersion = typeof(IShopifyDomainUtility).GetTypeInfo().Assembly.GetName().Version;

    private string UserAgent => $"ShopifySharp v{_assemblyVersion} (https://github.com/nozzlegear/shopifysharp)";

    /// <summary>
    /// A set of headers which can appear on a Shopify store's storefront.
    /// </summary>
    private static readonly HashSet<string> ShopifyProbeHeaders = new([
        "shopify-web-runtime",
        "shopify-complexity-score",
        "x-shopify-login-required",
        "X-ShopId",
    ], StringComparer.OrdinalIgnoreCase);

    public ShopifyDomainUtility()
    {
        _httpClientFactory = ResolveDependencies(null);
    }

    internal ShopifyDomainUtility(IServiceProvider serviceProvider)
    {
        _httpClientFactory = ResolveDependencies(serviceProvider);
    }

    private IHttpClientFactory ResolveDependencies(IServiceProvider? serviceProvider)
    {
        return InternalServiceResolver.GetServiceOrDefault<IHttpClientFactory>(serviceProvider,
            () => new InternalHttpClientFactory());
    }

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
            using var response = await client.SendAsync(msg, HttpCompletionOption.ResponseHeadersRead, cancellationToken);

            const string poweredByHeader = "powered-by";
            const string poweredByHeaderValue = "Shopify";

            foreach (var header in response.Headers)
            {
                if (ShopifyProbeHeaders.Contains(header.Key))
                    return true;

                // Special case: powered-by must be "Shopify". Many frameworks (e.g. caddy, nginx) set a "powered-by" header,
                // so we need to check the value here to be sure.
                if (!header.Key.Equals(poweredByHeader, StringComparison.OrdinalIgnoreCase))
                    continue;

                if (header.Value.Any(v => v.Equals(poweredByHeaderValue, StringComparison.OrdinalIgnoreCase)))
                    return true;
            }

            return false;
        }
        catch (HttpRequestException)
        {
            return false;
        }
    }
}
