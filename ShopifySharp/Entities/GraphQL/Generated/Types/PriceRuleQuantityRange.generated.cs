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
/// A quantity range within which the price rule is applicable.
/// </summary>
public record PriceRuleQuantityRange : IGraphQLObject
{
    /// <summary>
    /// The lower bound of the quantity range.
    /// </summary>
    [JsonPropertyName("greaterThan")]
    public int? greaterThan { get; set; } = null;

    /// <summary>
    /// The lower bound or equal of the quantity range.
    /// </summary>
    [JsonPropertyName("greaterThanOrEqualTo")]
    public int? greaterThanOrEqualTo { get; set; } = null;

    /// <summary>
    /// The upper bound of the quantity range.
    /// </summary>
    [JsonPropertyName("lessThan")]
    public int? lessThan { get; set; } = null;

    /// <summary>
    /// The upper bound or equal of the quantity range.
    /// </summary>
    [JsonPropertyName("lessThanOrEqualTo")]
    public int? lessThanOrEqualTo { get; set; } = null;
}