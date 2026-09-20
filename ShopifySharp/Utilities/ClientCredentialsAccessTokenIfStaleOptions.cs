#nullable enable
using System;

namespace ShopifySharp.Utilities;

public record ClientCredentialsAccessTokenIfStaleOptions
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

    /// The UTC timestamp at which the current access token expires, if known. Used to decide whether a new token is required without making a request.
    public DateTimeOffset? AccessTokenExpiresAtUtc { get; set; }

    /// How long before <c>AccessTokenExpiresAtUtc</c> to consider the token stale and re-issue it. Defaults to <see cref="TimeSpan.Zero"/>.
    public TimeSpan RefreshBeforeExpiry { get; set; } = TimeSpan.Zero;
}
