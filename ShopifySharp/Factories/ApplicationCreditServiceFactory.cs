#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IApplicationCreditServiceFactory
{
    /// Creates a new instance of the <see cref="IApplicationCreditService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IApplicationCreditService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IApplicationCreditService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IApplicationCreditService Create(ShopifyApiCredentials credentials);
}

public class ApplicationCreditServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IApplicationCreditServiceFactory
{
    /// <inheritDoc />
    public virtual IApplicationCreditService Create(string shopDomain, string accessToken)
    {
        IApplicationCreditService service = shopifyDomainUtility is null ? new ApplicationCreditService(shopDomain, accessToken) : new ApplicationCreditService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IApplicationCreditService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
