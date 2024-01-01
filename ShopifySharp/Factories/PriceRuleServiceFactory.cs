#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IPriceRuleServiceFactory
{
    /// Creates a new instance of the <see cref="IPriceRuleService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IPriceRuleService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IPriceRuleService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IPriceRuleService Create(ShopifyApiCredentials credentials);
}

public class PriceRuleServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IPriceRuleServiceFactory
{
    /// <inheritDoc />
    public virtual IPriceRuleService Create(string shopDomain, string accessToken)
    {
        IPriceRuleService service = shopifyDomainUtility is null ? new PriceRuleService(shopDomain, accessToken) : new PriceRuleService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IPriceRuleService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
