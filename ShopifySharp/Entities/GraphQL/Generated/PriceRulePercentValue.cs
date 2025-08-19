#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The value of a percent price rule.
/// </summary>
public record PriceRulePercentValue : PriceRuleValue, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The percent value of the price rule.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}