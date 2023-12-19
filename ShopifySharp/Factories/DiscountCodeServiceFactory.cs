#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IDiscountCodeServiceFactory
{
    /// Creates a new instance of the <see cref="IDiscountCodeService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IDiscountCodeService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IDiscountCodeService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IDiscountCodeService Create(ShopifyApiCredentials credentials);
}

public class DiscountCodeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IDiscountCodeServiceFactory
{
    /// <inheritDoc />
    public virtual IDiscountCodeService Create(string shopDomain, string accessToken)
    {
        IDiscountCodeService service = shopifyDomainUtility is null ? new DiscountCodeService(shopDomain, accessToken) : new DiscountCodeService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IDiscountCodeService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
