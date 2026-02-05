#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A money range within which the price rule is applicable.
/// </summary>
public record PriceRuleMoneyRange : IGraphQLObject
{
    /// <summary>
    /// The lower bound of the money range.
    /// </summary>
    [JsonPropertyName("greaterThan")]
    public decimal? greaterThan { get; set; } = null;

    /// <summary>
    /// The lower bound or equal of the money range.
    /// </summary>
    [JsonPropertyName("greaterThanOrEqualTo")]
    public decimal? greaterThanOrEqualTo { get; set; } = null;

    /// <summary>
    /// The upper bound of the money range.
    /// </summary>
    [JsonPropertyName("lessThan")]
    public decimal? lessThan { get; set; } = null;

    /// <summary>
    /// The upper bound or equal of the money range.
    /// </summary>
    [JsonPropertyName("lessThanOrEqualTo")]
    public decimal? lessThanOrEqualTo { get; set; } = null;
}