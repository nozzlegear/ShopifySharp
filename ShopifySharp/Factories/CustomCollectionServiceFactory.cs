#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface ICustomCollectionServiceFactory
{
    /// Creates a new instance of the <see cref="ICustomCollectionService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    ICustomCollectionService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="ICustomCollectionService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    ICustomCollectionService Create(ShopifyApiCredentials credentials);
}

public class CustomCollectionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : ICustomCollectionServiceFactory
{
    /// <inheritDoc />
    public virtual ICustomCollectionService Create(string shopDomain, string accessToken)
    {
        var service = new CustomCollectionService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICustomCollectionService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
