#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The value of a percent price rule.
/// </summary>
public record PriceRulePercentValue : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The percent value of the price rule.
    /// </summary>
    [JsonPropertyName("percentage")]
    public decimal? percentage { get; set; } = null;
}