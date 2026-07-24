#nullable enable
using System;

namespace ShopifySharp.Utilities;

public record RefreshOfflineAccessTokenIfStaleOptions
{
    public
#if NET6_0_OR_GREATER
    required
#endif
    string ShopDomain { get; set; } = null!;

    public
#if NET6_0_OR_GREATER
    required
#endif
    string ClientId { get; set; } = null!;

    public
#if NET6_0_OR_GREATER
    required
#endif
    string ClientSecret { get; set; } = null!;

    public
#if NET6_0_OR_GREATER
    required
#endif
    string RefreshToken { get; set; } = null!;

    public DateTimeOffset? AccessTokenExpiresAtUtc { get; set; }

    public DateTimeOffset? RefreshTokenExpiresAtUtc { get; set; }

    public TimeSpan RefreshBeforeExpiry { get; set; } = TimeSpan.Zero;
}
