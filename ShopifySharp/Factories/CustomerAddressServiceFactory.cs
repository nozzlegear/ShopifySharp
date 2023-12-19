#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface ICustomerAddressServiceFactory
{
    /// Creates a new instance of the <see cref="ICustomerAddressService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    ICustomerAddressService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="ICustomerAddressService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    ICustomerAddressService Create(ShopifyApiCredentials credentials);
}

public class CustomerAddressServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : ICustomerAddressServiceFactory
{
    /// <inheritDoc />
    public virtual ICustomerAddressService Create(string shopDomain, string accessToken)
    {
        ICustomerAddressService service = shopifyDomainUtility is null ? new CustomerAddressService(shopDomain, accessToken) : new CustomerAddressService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual ICustomerAddressService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
