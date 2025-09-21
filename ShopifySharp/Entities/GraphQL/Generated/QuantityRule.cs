#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The quantity rule for the product variant in a given context.
/// </summary>
public record QuantityRule : IGraphQLObject
{
    /// <summary>
    /// The value that specifies the quantity increment between minimum and maximum of the rule.
    /// Only quantities divisible by this value will be considered valid.
    /// The increment must be lower than or equal to the minimum and the maximum, and both minimum and maximum
    /// must be divisible by this value.
    /// </summary>
    [JsonPropertyName("increment")]
    public int? increment { get; set; } = null;

    /// <summary>
    /// Whether the quantity rule fields match one increment, one minimum and no maximum.
    /// </summary>
    [JsonPropertyName("isDefault")]
    public bool? isDefault { get; set; } = null;

    /// <summary>
    /// An optional value that defines the highest allowed quantity purchased by the customer.
    /// If defined, maximum must be lower than or equal to the minimum and must be a multiple of the increment.
    /// </summary>
    [JsonPropertyName("maximum")]
    public int? maximum { get; set; } = null;

    /// <summary>
    /// The value that defines the lowest allowed quantity purchased by the customer.
    /// The minimum must be a multiple of the quantity rule's increment.
    /// </summary>
    [JsonPropertyName("minimum")]
    public int? minimum { get; set; } = null;

    /// <summary>
    /// Whether the values of the quantity rule were explicitly set.
    /// </summary>
    [JsonPropertyName("originType")]
    public QuantityRuleOriginType? originType { get; set; } = null;

    /// <summary>
    /// The product variant for which the quantity rule is applied.
    /// </summary>
    [JsonPropertyName("productVariant")]
    public ProductVariant? productVariant { get; set; } = null;
}