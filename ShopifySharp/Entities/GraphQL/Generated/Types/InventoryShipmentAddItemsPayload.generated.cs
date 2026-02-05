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
/// Return type for `inventoryShipmentAddItems` mutation.
/// </summary>
public record InventoryShipmentAddItemsPayload : IGraphQLObject
{
    /// <summary>
    /// The list of added line items.
    /// </summary>
    [JsonPropertyName("addedItems")]
    public ICollection<InventoryShipmentLineItem>? addedItems { get; set; } = null;

    /// <summary>
    /// The inventory shipment with the added items.
    /// </summary>
    [JsonPropertyName("inventoryShipment")]
    public InventoryShipment? inventoryShipment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryShipmentAddItemsUserError>? userErrors { get; set; } = null;
}