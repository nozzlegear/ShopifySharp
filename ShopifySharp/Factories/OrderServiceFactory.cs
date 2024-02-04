#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IOrderServiceFactory : IServiceFactory<IOrderService>;

public class OrderServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IOrderServiceFactory
{
    /// <inheritDoc />
    public virtual IOrderService Create(string shopDomain, string accessToken)
    {
        IOrderService service = shopifyDomainUtility is null ? new OrderService(shopDomain, accessToken) : new OrderService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IOrderService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
