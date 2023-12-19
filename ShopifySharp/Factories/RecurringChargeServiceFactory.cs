#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IRecurringChargeServiceFactory
{
    /// Creates a new instance of the <see cref="IRecurringChargeService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IRecurringChargeService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IRecurringChargeService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IRecurringChargeService Create(ShopifyApiCredentials credentials);
}

public class RecurringChargeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IRecurringChargeServiceFactory
{
    /// <inheritDoc />
    public virtual IRecurringChargeService Create(string shopDomain, string accessToken)
    {
        IRecurringChargeService service = shopifyDomainUtility is null ? new RecurringChargeService(shopDomain, accessToken) : new RecurringChargeService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IRecurringChargeService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
