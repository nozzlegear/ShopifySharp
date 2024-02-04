#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IAssignedFulfillmentOrderServiceFactory : IServiceFactory<IAssignedFulfillmentOrderService>;

public class AssignedFulfillmentOrderServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IAssignedFulfillmentOrderServiceFactory
{
    /// <inheritDoc />
    public virtual IAssignedFulfillmentOrderService Create(string shopDomain, string accessToken)
    {
        IAssignedFulfillmentOrderService service = shopifyDomainUtility is null ? new AssignedFulfillmentOrderService(shopDomain, accessToken) : new AssignedFulfillmentOrderService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IAssignedFulfillmentOrderService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
