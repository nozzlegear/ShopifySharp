// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.
#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IGiftCardAdjustmentServiceFactory
{
    /// Creates a new instance of the <see cref="IGiftCardAdjustmentService" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IGiftCardAdjustmentService Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="IGiftCardAdjustmentService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IGiftCardAdjustmentService Create(ShopifyApiCredentials credentials);
}

public class GiftCardAdjustmentServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IGiftCardAdjustmentServiceFactory
{
    /// <inheritDoc />
    public virtual IGiftCardAdjustmentService Create(string shopDomain, string accessToken)
    {
        var service = new GiftCardAdjustmentService(shopDomain, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IGiftCardAdjustmentService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
