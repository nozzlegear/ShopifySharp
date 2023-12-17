#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

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

public class PriceRuleServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IPriceRuleServiceFactory
{
    /// <inheritDoc />
    public virtual IPriceRuleService Create(string shopDomain, string accessToken)
    {
        var service = new PriceRuleService(shopDomain, accessToken);

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
