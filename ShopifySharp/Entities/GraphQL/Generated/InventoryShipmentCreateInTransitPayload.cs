#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `inventoryShipmentCreateInTransit` mutation.
/// </summary>
public record InventoryShipmentCreateInTransitPayload : IGraphQLObject
{
    /// <summary>
    /// The created inventory shipment.
    /// </summary>
    [JsonPropertyName("inventoryShipment")]
    public InventoryShipment? inventoryShipment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryShipmentCreateInTransitUserError>? userErrors { get; set; } = null;
}