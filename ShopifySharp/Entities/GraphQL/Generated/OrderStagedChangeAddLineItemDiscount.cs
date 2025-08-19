#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The discount applied to an item that was added during the current order edit.
/// </summary>
public record OrderStagedChangeAddLineItemDiscount : OrderStagedChange, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The description of the discount.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The pricing value of the discount.
    /// </summary>
    [JsonPropertyName("value")]
    public PricingValue? @value { get; set; } = null;
}