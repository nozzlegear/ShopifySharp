#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `deliveryPromiseParticipantsUpdate` mutation.
/// </summary>
public record DeliveryPromiseParticipantsUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The promise participants that were added.
    /// </summary>
    [JsonPropertyName("promiseParticipants")]
    public ICollection<DeliveryPromiseParticipant>? promiseParticipants { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}