#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Returns enabled delivery promise participants.
/// </summary>
public record DeliveryPromiseParticipant : IGraphQLObject, INode
{
    /// <summary>
    /// The ID of the promise participant.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The resource that the participant is attached to.
    /// </summary>
    [JsonPropertyName("owner")]
    public DeliveryPromiseParticipantOwner? owner { get; set; } = null;

    /// <summary>
    /// The owner type of the participant.
    /// </summary>
    [JsonPropertyName("ownerType")]
    public DeliveryPromiseParticipantOwnerType? ownerType { get; set; } = null;
}