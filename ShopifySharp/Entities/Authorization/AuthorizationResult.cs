#nullable enable

using System;
using ShopifySharp.Entities;

// TODO: migrate this to the ShopifySharp.Entities namespace
namespace ShopifySharp;

/// <summary>
/// Represents the result of a successful OAuth authorization request to Shopify.
/// </summary>
public class AuthorizationResult(string accessToken, string[]? grantedScopes)
{
    /// <summary>
    /// The access token issued by Shopify. This token should be used in API calls to authenticate your app. You can
    /// pass it to most ShopifySharp service classes in their constructors.
    /// </summary>
    public string AccessToken { get; } = accessToken;

    /// <summary>
    /// The list of scopes that were granted by the shop owner during authorization.
    /// </summary>
    public string[] GrantedScopes { get; } = grantedScopes ?? [];

    /// <summary>
    /// Contains additional user-specific access information, but only when Shopify's
    /// "online access" (a.k.a. "per-user access") OAuth flow is used. Will be
    /// <c>null</c> for the default "offline access" flows.
    /// </summary>
    public OnlineAccessInfo? OnlineAccess { get; set; }

    /// <summary>
    /// Identifies whether this is a legacy permanent offline, expiring offline, or online access token.
    /// </summary>
    public ShopifyAccessTokenType Type =>
        OnlineAccess != null ? ShopifyAccessTokenType.Online :
        HasRefreshToken ? ShopifyAccessTokenType.ExpiringOffline :
        ShopifyAccessTokenType.LegacyPermanentOffline;

    private TimeSpan? _expiresIn;

    /// <summary>
    /// The duration for which the access token remains valid. This is returned for Shopify's
    /// online access tokens and expiring offline access tokens.
    /// </summary>
    /// <remarks>
    /// Note: The getter falls back to <c>OnlineAccess.ExpiresIn</c> to maintain backward compatibility with 
    /// legacy online access tokens that were serialized/stored in databases prior to PR 1257.
    /// </remarks>
    public TimeSpan? ExpiresIn
    {
        get => _expiresIn ?? OnlineAccess?.ExpiresIn;
        set => _expiresIn = value;
    }

    /// <summary>
    /// The refresh token returned by Shopify for expiring offline access tokens.
    /// </summary>
    public string? RefreshToken { get; set; }

    /// <summary>
    /// The duration for which the refresh token remains valid.
    /// </summary>
    public TimeSpan? RefreshTokenExpiresIn { get; set; }

    /// <summary>
    /// The UTC timestamp at which this authorization result was issued or refreshed.
    /// </summary>
    public DateTimeOffset IssuedAtUtc { get; set; } = DateTimeOffset.UtcNow;

    /// <summary>
    /// The UTC timestamp at which the access token expires, if Shopify returned an expiry.
    /// </summary>
    public DateTimeOffset? AccessTokenExpiresAtUtc => IssuedAtUtc + ExpiresIn;

    /// <summary>
    /// The UTC timestamp at which the refresh token expires, if Shopify returned an expiry.
    /// </summary>
    public DateTimeOffset? RefreshTokenExpiresAtUtc => IssuedAtUtc + RefreshTokenExpiresIn;

    /// <summary>
    /// Indicates whether this authorization result includes a refresh token.
    /// </summary>
    public bool HasRefreshToken => !string.IsNullOrWhiteSpace(RefreshToken);

    /// <summary>
    /// Indicates whether the authorization result was obtained using Shopify's
    /// "online access" (per-user) OAuth flow.
    /// </summary>
    #if NET6_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OnlineAccess))]
    #endif
    public bool IsOnlineAccess => OnlineAccess != null;

    /// <summary>
    /// Returns <c>true</c> when the access token has already expired.
    /// </summary>
    public bool AccessTokenHasExpired(DateTimeOffset? utcNow = null)
    {
        var expiresAtUtc = AccessTokenExpiresAtUtc;

        if (expiresAtUtc is null)
            return false;

        return (utcNow ?? DateTimeOffset.UtcNow) >= expiresAtUtc.Value;
    }

    /// <summary>
    /// Returns <c>true</c> when the refresh token has already expired.
    /// </summary>
    public bool RefreshTokenHasExpired(DateTimeOffset? utcNow = null)
    {
        var expiresAtUtc = RefreshTokenExpiresAtUtc;

        if (expiresAtUtc is null)
            return false;

        return (utcNow ?? DateTimeOffset.UtcNow) >= expiresAtUtc.Value;
    }

    /// <summary>
    /// Returns <c>true</c> when the access token is expired or will expire within the given buffer.
    /// </summary>
    public bool ShouldRefreshAccessToken(TimeSpan? refreshBeforeExpiry = null, DateTimeOffset? utcNow = null)
    {
        var expiresAtUtc = AccessTokenExpiresAtUtc;

        if (expiresAtUtc is null)
            return false;

        var now = utcNow ?? DateTimeOffset.UtcNow;
        var refreshBuffer = refreshBeforeExpiry ?? TimeSpan.Zero;

        return now >= expiresAtUtc.Value - refreshBuffer;
    }
}
