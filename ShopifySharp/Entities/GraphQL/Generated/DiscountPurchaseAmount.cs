#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A purchase amount in the context of a discount. This object can be used to
/// define the minimum purchase amount required for a discount to be applicable.
/// </summary>
public record DiscountPurchaseAmount : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The purchase amount in decimal format.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal? amount { get; set; } = null;
}