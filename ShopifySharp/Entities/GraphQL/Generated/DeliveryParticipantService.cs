#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A mail service provided by the participant.
/// </summary>
public record DeliveryParticipantService : IGraphQLObject
{
    /// <summary>
    /// Whether the service is active.
    /// </summary>
    [JsonPropertyName("active")]
    public bool? active { get; set; } = null;

    /// <summary>
    /// The name of the service.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}