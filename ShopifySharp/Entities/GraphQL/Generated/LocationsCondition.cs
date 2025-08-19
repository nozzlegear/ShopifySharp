#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A condition checking the location that the visitor is shopping from.
/// </summary>
public record LocationsCondition : IGraphQLObject
{
    /// <summary>
    /// The application level for the condition.
    /// </summary>
    [JsonPropertyName("applicationLevel")]
    public MarketConditionApplicationType? applicationLevel { get; set; } = null;

    /// <summary>
    /// The locations that comprise the market.
    /// </summary>
    [JsonPropertyName("locations")]
    public LocationConnection? locations { get; set; } = null;
}