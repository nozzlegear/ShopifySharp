#nullable enable

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
    /// Indicates whether the authorization result was obtained using Shopify's
    /// "online access" (per-user) OAuth flow.
    /// </summary>
    public bool IsOnlineAccess => OnlineAccess != null;
}
