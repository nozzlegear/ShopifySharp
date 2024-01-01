#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ICustomerServiceFactory
{
    /// Creates a new instance of the <see cref="ICustomerService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    ICustomerService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="ICustomerService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    ICustomerService Create(ShopifyApiCredentials credentials);
}

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
