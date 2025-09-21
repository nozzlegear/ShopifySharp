#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A condition checking the visitor's region.
/// </summary>
public record RegionsCondition : IGraphQLObject
{
    /// <summary>
    /// The application level for the condition.
    /// </summary>
    [JsonPropertyName("applicationLevel")]
    public MarketConditionApplicationType? applicationLevel { get; set; } = null;

    /// <summary>
    /// The regions that comprise the market.
    /// </summary>
    [JsonPropertyName("regions")]
    public MarketRegionConnection? regions { get; set; } = null;
}