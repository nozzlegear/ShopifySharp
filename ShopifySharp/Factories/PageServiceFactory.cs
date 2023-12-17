#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IPageServiceFactory
{
    /// Creates a new instance of the <see cref="IPageService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IPageService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IPageService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IPageService Create(ShopifyApiCredentials credentials);
}

public class PageServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IPageServiceFactory
{
    /// <inheritDoc />
    public virtual IPageService Create(string shopDomain, string accessToken)
    {
        var service = new PageService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IPageService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
