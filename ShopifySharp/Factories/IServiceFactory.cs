using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IServiceFactory<T>
    where T: IShopifyService
{
    /// Creates a new instance of the <see cref="T" /> with the given credentials.
    /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    T Create(string shopDomain, string accessToken);

    /// Creates a new instance of the <see cref="T" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    T Create(ShopifyApiCredentials credentials);
}
