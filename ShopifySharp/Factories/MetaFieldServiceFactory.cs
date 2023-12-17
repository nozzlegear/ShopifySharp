#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IMetaFieldServiceFactory
{
    /// Creates a new instance of the <see cref="IMetaFieldService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IMetaFieldService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IMetaFieldService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IMetaFieldService Create(ShopifyApiCredentials credentials);
}

public class MetaFieldServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IMetaFieldServiceFactory
{
    /// <inheritDoc />
    public virtual IMetaFieldService Create(string shopDomain, string accessToken)
    {
        var service = new MetaFieldService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IMetaFieldService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
