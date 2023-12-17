#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IDraftOrderServiceFactory
{
    /// Creates a new instance of the <see cref="IDraftOrderService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IDraftOrderService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IDraftOrderService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IDraftOrderService Create(ShopifyApiCredentials credentials);
}

public class DraftOrderServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IDraftOrderServiceFactory
{
    /// <inheritDoc />
    public virtual IDraftOrderService Create(string shopDomain, string accessToken)
    {
        var service = new DraftOrderService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IDraftOrderService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
