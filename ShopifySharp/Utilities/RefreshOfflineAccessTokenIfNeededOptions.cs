#nullable enable
using System;

namespace ShopifySharp.Utilities;

public record RefreshOfflineAccessTokenIfNeededOptions
{
    /// <summary>
    /// The store's *.myshopify.com url.
    /// </summary>
    public
#if NET6_0_OR_GREATER
    required
#endif
    string ShopDomain { get; set; } = null!;

    /// <summary>
    /// Your app's public Client ID, also known as its public API key.
    /// </summary>
    public
#if NET6_0_OR_GREATER
    required
#endif
    string ClientId { get; set; } = null!;

    /// <summary>
    /// Your app's Client Secret, also known as its secret API key.
    /// </summary>
    public
#if NET6_0_OR_GREATER
    required
#endif
    string ClientSecret { get; set; } = null!;

    /// <summary>
    /// The current authorization result to inspect and refresh when needed.
    /// </summary>
    public
#if NET6_0_OR_GREATER
    required
#endif
    AuthorizationResult AuthorizationResult { get; set; } = null!;

    /// <summary>
    /// Refresh the access token before it expires by this amount. Defaults to no early refresh buffer.
    /// </summary>
    public TimeSpan RefreshBeforeExpiry { get; set; } = TimeSpan.Zero;
}
