#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The fixed amount value of a discount, and whether the amount is applied to each
/// entitled item or spread evenly across the entitled items.
/// </summary>
public record DiscountAmount : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The value of the discount.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// If true, then the discount is applied to each of the entitled items. If false,
    /// then the amount is split across all of the entitled items.
    /// </summary>
    [JsonPropertyName("appliesOnEachItem")]
    public bool? appliesOnEachItem { get; set; } = null;
}