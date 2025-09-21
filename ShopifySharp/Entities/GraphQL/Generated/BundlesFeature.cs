#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the Bundles feature configuration for the shop.
/// </summary>
public record BundlesFeature : IGraphQLObject
{
    /// <summary>
    /// Whether a shop is configured properly to sell bundles.
    /// </summary>
    [JsonPropertyName("eligibleForBundles")]
    public bool? eligibleForBundles { get; set; } = null;

    /// <summary>
    /// The reason why a shop is not eligible for bundles.
    /// </summary>
    [JsonPropertyName("ineligibilityReason")]
    public string? ineligibilityReason { get; set; } = null;

    /// <summary>
    /// Whether a shop has any fixed bundle products or has a cartTransform function installed.
    /// </summary>
    [JsonPropertyName("sellsBundles")]
    public bool? sellsBundles { get; set; } = null;
}