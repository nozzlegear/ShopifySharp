#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A quantity of items in the context of a discount. This object can be used to
/// define the minimum quantity of items required to apply a discount.
/// Alternatively, it can be used to define the quantity of items that can be discounted.
/// </summary>
public record DiscountQuantity : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The quantity of items.
    /// </summary>
    [JsonPropertyName("quantity")]
    public ulong? quantity { get; set; } = null;
}