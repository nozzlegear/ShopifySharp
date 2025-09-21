#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create or update a region market condition.
/// </summary>
public record MarketConditionsRegionsInput : GraphQLInputObject<MarketConditionsRegionsInput>
{
    /// <summary>
    /// A type of market condition (e.g. ALL) to apply.
    /// </summary>
    [JsonPropertyName("applicationLevel")]
    public MarketConditionApplicationType? applicationLevel { get; set; } = null;

    /// <summary>
    /// A list of market region IDs to include in the market condition.
    /// </summary>
    [JsonPropertyName("regionIds")]
    public ICollection<string>? regionIds { get; set; } = null;

    /// <summary>
    /// A list of market regions to include in the market condition.
    /// </summary>
    [JsonPropertyName("regions")]
    public ICollection<MarketConditionsRegionInput>? regions { get; set; } = null;
}