#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the value of the discount and how it is applied.
/// </summary>
public record DiscountAmountInput : GraphQLInputObject<DiscountAmountInput>
{
    /// <summary>
    /// The value of the discount.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// If true, then the discount is applied to each of the entitled items. If false,
    /// then the amount is split across all of the entitled items.
    /// </summary>
    [JsonPropertyName("appliesOnEachItem")]
    public bool? appliesOnEachItem { get; set; } = null;
}