#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A change to the order representing the addition of a
/// custom line item. For example, you might want to add gift wrapping service
/// as a custom line item.
/// </summary>
public record OrderStagedChangeAddCustomItem : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The price of an individual item without any discounts applied. This value can't be negative.
    /// </summary>
    [JsonPropertyName("originalUnitPrice")]
    public MoneyV2? originalUnitPrice { get; set; } = null;

    /// <summary>
    /// The quantity of the custom item to add to the order. This value must be greater than zero.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The title of the custom item.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}