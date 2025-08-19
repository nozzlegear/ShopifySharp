#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `inventoryTransferRemoveItems` mutation.
/// </summary>
public record InventoryTransferRemoveItemsPayload : IGraphQLObject
{
    /// <summary>
    /// The transfer with line items removed.
    /// </summary>
    [JsonPropertyName("inventoryTransfer")]
    public InventoryTransfer? inventoryTransfer { get; set; } = null;

    /// <summary>
    /// The line items that have had their shippable quantity removed.
    /// </summary>
    [JsonPropertyName("removedQuantities")]
    public ICollection<InventoryTransferLineItemUpdate>? removedQuantities { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryTransferRemoveItemsUserError>? userErrors { get; set; } = null;
}