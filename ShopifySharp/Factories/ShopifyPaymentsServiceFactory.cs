#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IShopifyPaymentsServiceFactory : IServiceFactory<IShopifyPaymentsService>;

public class ShopifyPaymentsServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IShopifyPaymentsServiceFactory
{
    /// <inheritDoc />
    public virtual IShopifyPaymentsService Create(string shopDomain, string accessToken)
    {
        IShopifyPaymentsService service = shopifyDomainUtility is null ? new ShopifyPaymentsService(shopDomain, accessToken) : new ShopifyPaymentsService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IShopifyPaymentsService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
