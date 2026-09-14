#nullable enable
namespace ShopifySharp.Utilities;

public record ClientCredentialsAccessTokenOptions
{
    /// The store's *.myshopify.com URL.
    public
#if NET6_0_OR_GREATER
    required
#endif
    string ShopDomain { get; set; } = null!;

    /// Your app's Client ID, also known as its API key.
    public
#if NET6_0_OR_GREATER
    required
#endif
    string ClientId { get; set; } = null!;

    /// Your app's Client Secret. For a custom app, Shopify may also refer to this as its "password."
    public
#if NET6_0_OR_GREATER
    required
#endif
    string ClientSecret { get; set; } = null!;
}
