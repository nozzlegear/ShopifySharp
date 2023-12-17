#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ISmartCollectionServiceFactory
{
    /// Creates a new instance of the <see cref="ISmartCollectionService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    ISmartCollectionService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="ISmartCollectionService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    ISmartCollectionService Create(ShopifyApiCredentials credentials);
}

public class SmartCollectionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ISmartCollectionServiceFactory
{
    /// <inheritDoc />
    public virtual ISmartCollectionService Create(string shopDomain, string accessToken)
    {
        var service = new SmartCollectionService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ISmartCollectionService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
