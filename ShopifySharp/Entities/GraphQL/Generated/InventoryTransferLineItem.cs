#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a line item belonging to an inventory transfer.
/// </summary>
public record InventoryTransferLineItem : IGraphQLObject, INode
{
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
    /// The quantity of the item that has been picked for a draft shipment but not yet shipped.
    /// </summary>
    [JsonPropertyName("pickedForShipmentQuantity")]
    public int? pickedForShipmentQuantity { get; set; } = null;

    /// <summary>
    /// The quantity of the item that can be actioned upon, such as editing the item
    /// quantity on the transfer or adding to a shipment.
    /// </summary>
    [JsonPropertyName("processableQuantity")]
    public int? processableQuantity { get; set; } = null;

    /// <summary>
    /// The quantity of the item that can be shipped.
    /// </summary>
    [JsonPropertyName("shippableQuantity")]
    public int? shippableQuantity { get; set; } = null;

    /// <summary>
    /// The quantity of the item that has been shipped.
    /// </summary>
    [JsonPropertyName("shippedQuantity")]
    public int? shippedQuantity { get; set; } = null;

    /// <summary>
    /// The title of the product associated with this line item.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The total quantity of items being transferred.
    /// </summary>
    [JsonPropertyName("totalQuantity")]
    public int? totalQuantity { get; set; } = null;
}