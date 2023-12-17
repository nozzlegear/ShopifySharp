#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IRedirectServiceFactory
{
    /// Creates a new instance of the <see cref="IRedirectService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IRedirectService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IRedirectService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IRedirectService Create(ShopifyApiCredentials credentials);
}

public class RedirectServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IRedirectServiceFactory
{
    /// <inheritDoc />
    public virtual IRedirectService Create(string shopDomain, string accessToken)
    {
        var service = new RedirectService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IRedirectService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
