#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IChargeServiceFactory
{
    /// Creates a new instance of the <see cref="IChargeService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IChargeService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IChargeService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IChargeService Create(ShopifyApiCredentials credentials);
}

public class ChargeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IChargeServiceFactory
{
    /// <inheritDoc />
    public virtual IChargeService Create(string shopDomain, string accessToken)
    {
        var service = new ChargeService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IChargeService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
