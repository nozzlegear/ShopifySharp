#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Resource limits of a shop.
/// </summary>
public record ShopResourceLimits : IGraphQLObject
{
    /// <summary>
    /// Maximum number of locations allowed.
    /// </summary>
    [JsonPropertyName("locationLimit")]
    public int? locationLimit { get; set; } = null;

    /// <summary>
    /// Maximum number of product options allowed.
    /// </summary>
    [JsonPropertyName("maxProductOptions")]
    public int? maxProductOptions { get; set; } = null;

    /// <summary>
    /// The maximum number of variants allowed per product.
    /// </summary>
    [JsonPropertyName("maxProductVariants")]
    public int? maxProductVariants { get; set; } = null;

    /// <summary>
    /// Whether the shop has reached the limit of the number of URL redirects it can make for resources.
    /// </summary>
    [JsonPropertyName("redirectLimitReached")]
    public bool? redirectLimitReached { get; set; } = null;
}