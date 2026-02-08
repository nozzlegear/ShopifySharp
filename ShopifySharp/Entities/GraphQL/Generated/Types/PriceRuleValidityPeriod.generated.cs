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
/// A time period during which a price rule is applicable.
/// </summary>
public record PriceRuleValidityPeriod : IGraphQLObject
{
    /// <summary>
    /// The time after which the price rule becomes invalid.
    /// </summary>
    [JsonPropertyName("end")]
    public DateTimeOffset? end { get; set; } = null;

    /// <summary>
    /// The time after which the price rule is valid.
    /// </summary>
    [JsonPropertyName("start")]
    public DateTimeOffset? start { get; set; } = null;
}