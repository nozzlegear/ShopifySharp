#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICollectServiceFactory
{
    /// Creates a new instance of the <see cref="ICollectService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    ICollectService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="ICollectService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    ICollectService Create(ShopifyApiCredentials credentials);
}

public class CollectServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICollectServiceFactory
{
    /// <inheritDoc />
    public virtual ICollectService Create(string shopDomain, string accessToken)
    {
        var service = new CollectService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICollectService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
