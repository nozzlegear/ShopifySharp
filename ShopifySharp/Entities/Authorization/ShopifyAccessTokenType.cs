#nullable enable

namespace ShopifySharp;

public enum ShopifyAccessTokenType
{
    /// <summary>
    /// A legacy, permanent offline access token. Does not expire and has no refresh token.
    /// </summary>
    LegacyPermanentOffline,

    /// <summary>
    /// An expiring offline access token. Expires and must be refreshed programmatically using a refresh token.
    /// </summary>
    ExpiringOffline,

    /// <summary>
    /// An online access token (per-user). Expires and cannot be refreshed programmatically; requires user interaction to renew.
    /// </summary>
    Online
}
