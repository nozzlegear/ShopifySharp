#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The minimum quantity of items required for the discount to apply.
/// </summary>
public record DiscountMinimumQuantity : DiscountMinimumRequirement, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The minimum quantity of items that's required for the discount to be applied.
    /// </summary>
    [JsonPropertyName("greaterThanOrEqualToQuantity")]
    public ulong? greaterThanOrEqualToQuantity { get; set; } = null;
}