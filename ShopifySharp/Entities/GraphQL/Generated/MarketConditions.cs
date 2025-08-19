#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The conditions that determine whether a visitor is in a market.
/// </summary>
public record MarketConditions : IGraphQLObject
{
    /// <summary>
    /// The company location conditions that determine whether a visitor is in the market.
    /// </summary>
    [JsonPropertyName("companyLocationsCondition")]
    public CompanyLocationsCondition? companyLocationsCondition { get; set; } = null;

    /// <summary>
    /// The set of condition types that are defined for the market.
    /// </summary>
    [JsonPropertyName("conditionTypes")]
    public ICollection<MarketConditionType>? conditionTypes { get; set; } = null;

    /// <summary>
    /// The retail location conditions that determine whether a visitor is in the market.
    /// </summary>
    [JsonPropertyName("locationsCondition")]
    public LocationsCondition? locationsCondition { get; set; } = null;

    /// <summary>
    /// The region conditions that determine whether a visitor is in the market.
    /// </summary>
    [JsonPropertyName("regionsCondition")]
    public RegionsCondition? regionsCondition { get; set; } = null;
}