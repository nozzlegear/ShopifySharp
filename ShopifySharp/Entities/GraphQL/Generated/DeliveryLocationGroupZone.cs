#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Links a location group with a zone and the associated method definitions.
/// </summary>
public record DeliveryLocationGroupZone : IGraphQLObject
{
    /// <summary>
    /// The number of method definitions for the zone.
    /// </summary>
    [JsonPropertyName("methodDefinitionCounts")]
    public DeliveryMethodDefinitionCounts? methodDefinitionCounts { get; set; } = null;

    /// <summary>
    /// The method definitions associated to a zone and location group.
    /// </summary>
    [JsonPropertyName("methodDefinitions")]
    public DeliveryMethodDefinitionConnection? methodDefinitions { get; set; } = null;

    /// <summary>
    /// The zone associated to a location group.
    /// </summary>
    [JsonPropertyName("zone")]
    public DeliveryZone? zone { get; set; } = null;
}