#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IShopPlanServiceFactory : IServiceFactory<IShopPlanService>;

public class ShopPlanServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IShopPlanServiceFactory
{
    /// <inheritDoc />
    public virtual IShopPlanService Create(string shopDomain, string accessToken)
    {
        IShopPlanService service = shopifyDomainUtility is null ? new ShopPlanService(shopDomain, accessToken, dependencyContainer: null) : new ShopPlanService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IShopPlanService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
