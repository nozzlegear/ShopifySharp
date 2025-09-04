#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The quantity of items discounted, the discount value, and how the discount will be applied.
/// </summary>
public record DiscountOnQuantity : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The discount's effect on qualifying items.
    /// </summary>
    [JsonPropertyName("effect")]
    public DiscountEffect? effect { get; set; } = null;

    /// <summary>
    /// The number of items being discounted. The customer must have at least this
    /// many items of specified products or product variants in their order to be
    /// eligible for the discount.
    /// </summary>
    [JsonPropertyName("quantity")]
    public DiscountQuantity? quantity { get; set; } = null;
}