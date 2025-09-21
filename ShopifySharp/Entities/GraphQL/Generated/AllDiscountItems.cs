#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Targets all items the cart for a specified discount.
/// </summary>
public record AllDiscountItems : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// Whether all items are eligible for the discount. This value always returns `true`.
    /// </summary>
    [JsonPropertyName("allItems")]
    public bool? allItems { get; set; } = null;
}