#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `locationLocalPickupDisable` mutation.
/// </summary>
public record LocationLocalPickupDisablePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the location for which local pickup was disabled.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DeliveryLocationLocalPickupSettingsError>? userErrors { get; set; } = null;
}