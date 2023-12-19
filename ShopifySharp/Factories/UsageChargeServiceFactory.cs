#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IUsageChargeServiceFactory
{
    /// Creates a new instance of the <see cref="IUsageChargeService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IUsageChargeService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IUsageChargeService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IUsageChargeService Create(ShopifyApiCredentials credentials);
}

public class UsageChargeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IUsageChargeServiceFactory
{
    /// <inheritDoc />
    public virtual IUsageChargeService Create(string shopDomain, string accessToken)
    {
        IUsageChargeService service = shopifyDomainUtility is null ? new UsageChargeService(shopDomain, accessToken) : new UsageChargeService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IUsageChargeService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
