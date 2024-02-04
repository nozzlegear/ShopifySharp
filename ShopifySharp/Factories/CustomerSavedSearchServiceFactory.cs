#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ICustomerSavedSearchServiceFactory : IServiceFactory<ICustomerSavedSearchService>;

public class CustomerSavedSearchServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ICustomerSavedSearchServiceFactory
{
    /// <inheritDoc />
    public virtual ICustomerSavedSearchService Create(string shopDomain, string accessToken)
    {
        ICustomerSavedSearchService service = shopifyDomainUtility is null ? new CustomerSavedSearchService(shopDomain, accessToken) : new CustomerSavedSearchService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICustomerSavedSearchService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
