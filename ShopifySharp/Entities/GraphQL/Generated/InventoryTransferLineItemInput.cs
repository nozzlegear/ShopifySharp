#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a line item on an inventory transfer.
/// </summary>
public record InventoryTransferLineItemInput : GraphQLInputObject<InventoryTransferLineItemInput>
{
    /// <summary>
    /// The inventory item ID for the transfer line item.
    /// </summary>
    [JsonPropertyName("inventoryItemId")]
    public string? inventoryItemId { get; set; } = null;

    /// <summary>
    /// The quantity for the transfer line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}