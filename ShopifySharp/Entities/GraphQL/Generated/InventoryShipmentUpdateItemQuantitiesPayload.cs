#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `inventoryShipmentUpdateItemQuantities` mutation.
/// </summary>
public record InventoryShipmentUpdateItemQuantitiesPayload : IGraphQLObject
{
    /// <summary>
    /// The inventory shipment with updated item quantities.
    /// </summary>
    [JsonPropertyName("shipment")]
    public InventoryShipment? shipment { get; set; } = null;

    /// <summary>
    /// The updated item quantities.
    /// </summary>
    [JsonPropertyName("updatedLineItems")]
    public ICollection<InventoryShipmentLineItem>? updatedLineItems { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryShipmentUpdateItemQuantitiesUserError>? userErrors { get; set; } = null;
}