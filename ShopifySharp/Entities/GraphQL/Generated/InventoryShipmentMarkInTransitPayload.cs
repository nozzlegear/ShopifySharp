#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `inventoryShipmentMarkInTransit` mutation.
/// </summary>
public record InventoryShipmentMarkInTransitPayload : IGraphQLObject
{
    /// <summary>
    /// The marked in transit inventory shipment.
    /// </summary>
    [JsonPropertyName("inventoryShipment")]
    public InventoryShipment? inventoryShipment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryShipmentMarkInTransitUserError>? userErrors { get; set; } = null;
}