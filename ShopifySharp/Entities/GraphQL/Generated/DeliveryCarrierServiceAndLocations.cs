#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A carrier service and the associated list of shop locations.
/// </summary>
public record DeliveryCarrierServiceAndLocations : IGraphQLObject
{
    /// <summary>
    /// The carrier service.
    /// </summary>
    [JsonPropertyName("carrierService")]
    public DeliveryCarrierService? carrierService { get; set; } = null;

    /// <summary>
    /// The list of locations that support this carrier service.
    /// </summary>
    [JsonPropertyName("locations")]
    public ICollection<Location>? locations { get; set; } = null;
}