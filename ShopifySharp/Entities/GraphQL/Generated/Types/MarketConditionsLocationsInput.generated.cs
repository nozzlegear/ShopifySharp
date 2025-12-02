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
/// The input fields required to create or update a location market condition.
/// </summary>
public record MarketConditionsLocationsInput : GraphQLInputObject<MarketConditionsLocationsInput>
{
    /// <summary>
    /// A type of market condition (e.g. ALL) to apply.
    /// </summary>
    [JsonPropertyName("applicationLevel")]
    public MarketConditionApplicationType? applicationLevel { get; set; } = null;

    /// <summary>
    /// A list of location IDs to include in the market condition.
    /// </summary>
    [JsonPropertyName("locationIds")]
    public ICollection<string>? locationIds { get; set; } = null;
}