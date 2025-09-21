#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A condition checking the company location a visitor is purchasing for.
/// </summary>
public record CompanyLocationsCondition : IGraphQLObject
{
    /// <summary>
    /// The application level for the condition.
    /// </summary>
    [JsonPropertyName("applicationLevel")]
    public MarketConditionApplicationType? applicationLevel { get; set; } = null;

    /// <summary>
    /// The company locations that comprise the market.
    /// </summary>
    [JsonPropertyName("companyLocations")]
    public CompanyLocationConnection? companyLocations { get; set; } = null;
}