#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `locationLocalPickupEnable` mutation.
/// </summary>
public record LocationLocalPickupEnablePayload : IGraphQLObject
{
    /// <summary>
    /// The local pickup settings that were enabled.
    /// </summary>
    [JsonPropertyName("localPickupSettings")]
    public DeliveryLocalPickupSettings? localPickupSettings { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DeliveryLocationLocalPickupSettingsError>? userErrors { get; set; } = null;
}