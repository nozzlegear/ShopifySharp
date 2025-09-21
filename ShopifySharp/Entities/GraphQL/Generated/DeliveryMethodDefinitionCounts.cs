#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The number of method definitions for a zone, separated into merchant-owned and participant definitions.
/// </summary>
public record DeliveryMethodDefinitionCounts : IGraphQLObject
{
    /// <summary>
    /// The number of participant method definitions for the specified zone.
    /// </summary>
    [JsonPropertyName("participantDefinitionsCount")]
    public int? participantDefinitionsCount { get; set; } = null;

    /// <summary>
    /// The number of merchant-defined method definitions for the specified zone.
    /// </summary>
    [JsonPropertyName("rateDefinitionsCount")]
    public int? rateDefinitionsCount { get; set; } = null;
}