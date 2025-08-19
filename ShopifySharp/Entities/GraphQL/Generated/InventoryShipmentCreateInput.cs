#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields to add a shipment.
/// </summary>
public record InventoryShipmentCreateInput : GraphQLInputObject<InventoryShipmentCreateInput>
{
    /// <summary>
    /// The list of line items for the inventory shipment.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ICollection<InventoryShipmentLineItemInput>? lineItems { get; set; } = null;

    /// <summary>
    /// The ID of the inventory movement (transfer or purchase order) this shipment belongs to.
    /// </summary>
    [JsonPropertyName("movementId")]
    public string? movementId { get; set; } = null;

    /// <summary>
    /// The tracking information for the shipment.
    /// </summary>
    [JsonPropertyName("trackingInput")]
    public InventoryShipmentTrackingInput? trackingInput { get; set; } = null;
}