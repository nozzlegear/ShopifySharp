#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a local pickup setting associated with a location.
/// </summary>
public record DeliveryLocationLocalPickupEnableInput : GraphQLInputObject<DeliveryLocationLocalPickupEnableInput>
{
    /// <summary>
    /// The instructions for the local pickup.
    /// </summary>
    [JsonPropertyName("instructions")]
    public string? instructions { get; set; } = null;

    /// <summary>
    /// The ID of the location associated with the location setting.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;

    /// <summary>
    /// The time of the local pickup.
    /// </summary>
    [JsonPropertyName("pickupTime")]
    public DeliveryLocalPickupTime? pickupTime { get; set; } = null;
}