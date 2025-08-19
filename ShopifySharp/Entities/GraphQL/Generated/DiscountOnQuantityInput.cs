#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the quantity of items discounted and the discount value.
/// </summary>
public record DiscountOnQuantityInput : GraphQLInputObject<DiscountOnQuantityInput>
{
    /// <summary>
    /// The percentage value of the discount.
    /// </summary>
    [JsonPropertyName("effect")]
    public DiscountEffectInput? effect { get; set; } = null;

    /// <summary>
    /// The quantity of items that are discounted.
    /// </summary>
    [JsonPropertyName("quantity")]
    public ulong? quantity { get; set; } = null;
}