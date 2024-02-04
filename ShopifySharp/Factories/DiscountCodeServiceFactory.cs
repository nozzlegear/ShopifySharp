#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IDiscountCodeServiceFactory : IServiceFactory<IDiscountCodeService>;

public class DiscountCodeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IDiscountCodeServiceFactory
{
    /// <inheritDoc />
    public virtual IDiscountCodeService Create(string shopDomain, string accessToken)
    {
        IDiscountCodeService service = shopifyDomainUtility is null ? new DiscountCodeService(shopDomain, accessToken) : new DiscountCodeService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IDiscountCodeService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
