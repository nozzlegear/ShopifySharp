#nullable enable
namespace ShopifySharp.Utilities;

public record RefreshAccessTokenOptions
{
    /// The store's *.myshopify.com url
    public
#if NET6_0_OR_GREATER
    required
#endif
    string ShopDomain { get; set; } = null!;

    /// Your app's public Client ID, also known as its public API key.
    public
#if NET6_0_OR_GREATER
    required
#endif
	string ClientId { get; set; } = null!;

    /// Your app's Client Secret, also known as its secret API key.
    public
#if NET6_0_OR_GREATER
    required
#endif
	string ClientSecret { get; set; } = null!;

    /// The app's refresh token
    public
#if NET6_0_OR_GREATER
    required
#endif
	string RefreshToken { get; set; } = null!;

    /// The existing store access token
    public
#if NET6_0_OR_GREATER
    required
#endif
	string ExistingStoreAccessToken { get; set; } = null!;
}
