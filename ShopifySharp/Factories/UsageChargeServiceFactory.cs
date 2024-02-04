#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IUsageChargeServiceFactory : IServiceFactory<IUsageChargeService>;

public class UsageChargeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IUsageChargeServiceFactory
{
    /// <inheritDoc />
    public virtual IUsageChargeService Create(string shopDomain, string accessToken)
    {
        IUsageChargeService service = shopifyDomainUtility is null ? new UsageChargeService(shopDomain, accessToken) : new UsageChargeService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IUsageChargeService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
