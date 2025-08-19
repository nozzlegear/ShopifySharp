#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The value of a fixed amount price rule.
/// </summary>
public record PriceRuleFixedAmountValue : PriceRuleValue, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The monetary value of the price rule.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal? amount { get; set; } = null;
}