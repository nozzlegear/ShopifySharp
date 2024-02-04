#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IFulfillmentEventServiceFactory : IServiceFactory<IFulfillmentEventService>;

public class FulfillmentEventServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IFulfillmentEventServiceFactory
{
    /// <inheritDoc />
    public virtual IFulfillmentEventService Create(string shopDomain, string accessToken)
    {
        IFulfillmentEventService service = shopifyDomainUtility is null ? new FulfillmentEventService(shopDomain, accessToken) : new FulfillmentEventService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IFulfillmentEventService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
