#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a single line item within an inventory shipment.
/// </summary>
public record InventoryShipmentLineItem : IGraphQLObject, INode
{
    /// <summary>
    /// The quantity of items that were accepted in this shipment line item.
    /// </summary>
    [JsonPropertyName("acceptedQuantity")]
    public int? acceptedQuantity { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The inventory item associated with this line item.
    /// </summary>
    [JsonPropertyName("inventoryItem")]
    public InventoryItem? inventoryItem { get; set; } = null;

    /// <summary>
    /// The quantity of items in this shipment line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The quantity of items that were rejected in this shipment line item.
    /// </summary>
    [JsonPropertyName("rejectedQuantity")]
    public int? rejectedQuantity { get; set; } = null;

    /// <summary>
    /// The total quantity of units that haven't been received (neither accepted or rejected) in this shipment line item.
    /// </summary>
    [JsonPropertyName("unreceivedQuantity")]
    public int? unreceivedQuantity { get; set; } = null;
}