#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IGiftCardServiceFactory : IServiceFactory<IGiftCardService>;

public class GiftCardServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IGiftCardServiceFactory
{
    /// <inheritDoc />
    public virtual IGiftCardService Create(string shopDomain, string accessToken)
    {
        IGiftCardService service = shopifyDomainUtility is null ? new GiftCardService(shopDomain, accessToken) : new GiftCardService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IGiftCardService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
