#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `inventoryShipmentSetTracking` mutation.
/// </summary>
public record InventoryShipmentSetTrackingPayload : IGraphQLObject
{
    /// <summary>
    /// The inventory shipment with the edited tracking info.
    /// </summary>
    [JsonPropertyName("inventoryShipment")]
    public InventoryShipment? inventoryShipment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryShipmentSetTrackingUserError>? userErrors { get; set; } = null;
}