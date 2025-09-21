#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to create or update a company location market condition.
/// </summary>
public record MarketConditionsCompanyLocationsInput : GraphQLInputObject<MarketConditionsCompanyLocationsInput>
{
    /// <summary>
    /// A type of market condition (e.g. ALL) to apply.
    /// </summary>
    [JsonPropertyName("applicationLevel")]
    public MarketConditionApplicationType? applicationLevel { get; set; } = null;

    /// <summary>
    /// A list of company location IDs to include in the market condition.
    /// </summary>
    [JsonPropertyName("companyLocationIds")]
    public ICollection<string>? companyLocationIds { get; set; } = null;
}