#nullable enable
using System;

namespace ShopifySharp.Entities;

/// <summary>
/// Represents additional authorization details when using Shopify's
/// "online access" (per-user access) OAuth flow.
/// </summary>
public class OnlineAccessInfo
{
    /// <summary>
    /// The duration for which the access token is valid.
    /// </summary>
    public TimeSpan ExpiresIn { get; set; } = TimeSpan.Zero;

    /// <summary>
    /// The list of scopes granted specifically to the associated user.
    /// </summary>
    public string[] AssociatedUserScopes { get; set; } = [];

    /// <summary>
    /// Information about the user who authorized the app.
    /// </summary>
    public AssociatedUser AssociatedUser { get; set; } = null!;
}
