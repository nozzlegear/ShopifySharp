#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

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

public class CustomCollectionServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ICustomCollectionServiceFactory
{
    /// <inheritDoc />
    public virtual ICustomCollectionService Create(string shopDomain, string accessToken)
    {
        ICustomCollectionService service = shopifyDomainUtility is null ? new CustomCollectionService(shopDomain, accessToken) : new CustomCollectionService(shopDomain, accessToken, shopifyDomainUtility);

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
