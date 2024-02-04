#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IStorefrontAccessTokenServiceFactory : IServiceFactory<IStorefrontAccessTokenService>;

public class StorefrontAccessTokenServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IStorefrontAccessTokenServiceFactory
{
    /// <inheritDoc />
    public virtual IStorefrontAccessTokenService Create(string shopDomain, string accessToken)
    {
        IStorefrontAccessTokenService service = shopifyDomainUtility is null ? new StorefrontAccessTokenService(shopDomain, accessToken) : new StorefrontAccessTokenService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IStorefrontAccessTokenService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
