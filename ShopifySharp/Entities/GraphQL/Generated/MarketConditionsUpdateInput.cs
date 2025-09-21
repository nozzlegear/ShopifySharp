#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to update a market condition.
/// </summary>
public record MarketConditionsUpdateInput : GraphQLInputObject<MarketConditionsUpdateInput>
{
    /// <summary>
    /// The conditions to update to the market condition.
    /// </summary>
    [JsonPropertyName("conditionsToAdd")]
    public MarketConditionsInput? conditionsToAdd { get; set; } = null;

    /// <summary>
    /// The conditions to delete from the market condition.
    /// </summary>
    [JsonPropertyName("conditionsToDelete")]
    public MarketConditionsInput? conditionsToDelete { get; set; } = null;
}