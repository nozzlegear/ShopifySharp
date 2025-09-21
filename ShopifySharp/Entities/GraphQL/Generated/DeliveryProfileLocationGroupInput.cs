#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a location group associated to a delivery profile.
/// </summary>
public record DeliveryProfileLocationGroupInput : GraphQLInputObject<DeliveryProfileLocationGroupInput>
{
    /// <summary>
    /// The globally-unique ID of the delivery profile location group.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The list of location IDs to be moved to this location group.
    /// </summary>
    [JsonPropertyName("locations")]
    public ICollection<string>? locations { get; set; } = null;

    /// <summary>
    /// The list of location IDs to be added to this location group.
    /// **Note:** due to API input array limits, a maximum of 250 items can be sent per each request.
    /// </summary>
    [JsonPropertyName("locationsToAdd")]
    public ICollection<string>? locationsToAdd { get; set; } = null;

    /// <summary>
    /// The list of location IDs to be removed from this location group.
    /// **Note:** due to API input array limits, a maximum of 250 items can be sent per each request.
    /// </summary>
    [JsonPropertyName("locationsToRemove")]
    public ICollection<string>? locationsToRemove { get; set; } = null;

    /// <summary>
    /// The list of location group zones to create.
    /// **Note:** due to the potential complexity of the nested data, it is
    /// recommended to send no more than 5 zones per each request.
    /// </summary>
    [JsonPropertyName("zonesToCreate")]
    public ICollection<DeliveryLocationGroupZoneInput>? zonesToCreate { get; set; } = null;

    /// <summary>
    /// The list of location group zones to update.
    /// **Note:** due to the potential complexity of the nested data, it is
    /// recommended to send no more than 5 zones per each request.
    /// </summary>
    [JsonPropertyName("zonesToUpdate")]
    public ICollection<DeliveryLocationGroupZoneInput>? zonesToUpdate { get; set; } = null;
}