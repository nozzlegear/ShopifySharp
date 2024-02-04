#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IFulfillmentServiceFactory : IServiceFactory<IFulfillmentService>;

public class FulfillmentServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IFulfillmentServiceFactory
{
    /// <inheritDoc />
    public virtual IFulfillmentService Create(string shopDomain, string accessToken)
    {
        IFulfillmentService service = shopifyDomainUtility is null ? new FulfillmentService(shopDomain, accessToken) : new FulfillmentService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IFulfillmentService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
