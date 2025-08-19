#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Merchant approval for accelerated onboarding to channel integration apps.
/// </summary>
public record MerchantApprovalSignals : IGraphQLObject
{
    /// <summary>
    /// Whether the shop's Shopify Payments account identity is verified. Returns
    /// `false` if the identity is unverified or if the shop doesn't have a Shopify
    /// Payments account.
    /// </summary>
    [JsonPropertyName("identityVerified")]
    public bool? identityVerified { get; set; } = null;

    /// <summary>
    /// Whether Shopify has pre-verified the merchant's business for onboarding to
    /// channel integration apps. Returns `false` if the shop isn't marked for verification.
    /// </summary>
    [JsonPropertyName("verifiedByShopify")]
    public bool? verifiedByShopify { get; set; } = null;

    /// <summary>
    /// Which tier of the Shopify verification was determined for the merchant's
    /// business for onboarding to channel integration apps.
    /// </summary>
    [JsonPropertyName("verifiedByShopifyTier")]
    public string? verifiedByShopifyTier { get; set; } = null;
}