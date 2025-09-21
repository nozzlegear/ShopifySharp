#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A shipping line item involved in order editing that may be newly added or have new changes applied.
/// </summary>
public record CalculatedShippingLine : IGraphQLObject
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The price of the shipping line when sold and before applying discounts. This
    /// field includes taxes if `Order.taxesIncluded` is true. Otherwise, this field
    /// doesn't include taxes for the shipping line.
    /// </summary>
    [JsonPropertyName("price")]
    public MoneyBag? price { get; set; } = null;

    /// <summary>
    /// The staged status of the shipping line.
    /// </summary>
    [JsonPropertyName("stagedStatus")]
    public CalculatedShippingLineStagedStatus? stagedStatus { get; set; } = null;

    /// <summary>
    /// The title of the shipping line.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}