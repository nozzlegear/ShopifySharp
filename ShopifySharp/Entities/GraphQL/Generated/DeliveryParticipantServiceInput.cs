#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a shipping service provided by a participant.
/// </summary>
public record DeliveryParticipantServiceInput : GraphQLInputObject<DeliveryParticipantServiceInput>
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