#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ICustomerServiceFactory : IServiceFactory<ICustomerService>;

public class CustomerServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ICustomerServiceFactory
{
    /// <inheritDoc />
    public virtual ICustomerService Create(string shopDomain, string accessToken)
    {
        ICustomerService service = shopifyDomainUtility is null ? new CustomerService(shopDomain, accessToken) : new CustomerService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICustomerService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
