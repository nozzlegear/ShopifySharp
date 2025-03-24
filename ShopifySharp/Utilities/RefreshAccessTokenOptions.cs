#if NET8_0_OR_GREATER
#nullable enable
namespace ShopifySharp.Utilities;

public record RefreshAccessTokenOptions
{
    /// The store's *.myshopify.com url
    public required string ShopDomain { get; init; }
    /// Your app's public Client ID, also known as its public API key.
    public required string ClientId { get; init; }
    /// Your app's Client Secret, also known as its secret API key.
    public required string ClientSecret { get; init; }
    /// The app's refresh token
    public required string RefreshToken { get; init; }
    /// The existing store access token
    public required string ExistingStoreAccessToken { get; init; }
}
#endif