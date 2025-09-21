#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create or update the market conditions.
/// </summary>
public record MarketConditionsInput : GraphQLInputObject<MarketConditionsInput>
{
    /// <summary>
    /// The company locations to include in the market conditions.
    /// </summary>
    [JsonPropertyName("companyLocationsCondition")]
    public MarketConditionsCompanyLocationsInput? companyLocationsCondition { get; set; } = null;

    /// <summary>
    /// The locations to include in the market conditions.
    /// </summary>
    [JsonPropertyName("locationsCondition")]
    public MarketConditionsLocationsInput? locationsCondition { get; set; } = null;

    /// <summary>
    /// The regions to include in the market conditions.
    /// </summary>
    [JsonPropertyName("regionsCondition")]
    public MarketConditionsRegionsInput? regionsCondition { get; set; } = null;
}