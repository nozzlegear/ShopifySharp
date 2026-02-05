#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the per-order quantity rule to be applied on the product variant.
/// </summary>
public record QuantityRuleInput : GraphQLInputObject<QuantityRuleInput>
{
    /// <summary>
    /// The quantity increment.
    /// </summary>
    [JsonPropertyName("increment")]
    public int? increment { get; set; } = null;

    /// <summary>
    /// The maximum quantity.
    /// </summary>
    [JsonPropertyName("maximum")]
    public int? maximum { get; set; } = null;

    /// <summary>
    /// The minimum quantity.
    /// </summary>
    [JsonPropertyName("minimum")]
    public int? minimum { get; set; } = null;

    /// <summary>
    /// Product variant on which to apply the quantity rule.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;
}