#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICollectionServiceFactory
{
    /// Creates a new instance of the <see cref="ICollectionService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    ICollectionService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="ICollectionService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    ICollectionService Create(ShopifyApiCredentials credentials);
}

public class CollectionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICollectionServiceFactory
{
    /// <inheritDoc />
    public virtual ICollectionService Create(string shopDomain, string accessToken)
    {
        var service = new CollectionService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICollectionService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
