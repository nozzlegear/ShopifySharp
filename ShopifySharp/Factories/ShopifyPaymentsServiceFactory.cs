// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IShopifyPaymentsServiceFactory
{
    /// Creates a new instance of the <see cref="IShopifyPaymentsService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IShopifyPaymentsService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IShopifyPaymentsService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IShopifyPaymentsService Create(ShopifyApiCredentials credentials);
}

public class ShopifyPaymentsServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IShopifyPaymentsServiceFactory
{
    /// <inheritDoc />
    public virtual IShopifyPaymentsService Create(string shopDomain, string accessToken)
    {
        var service = new ShopifyPaymentsService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IShopifyPaymentsService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
