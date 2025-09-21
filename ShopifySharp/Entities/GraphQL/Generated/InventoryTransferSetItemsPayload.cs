#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `inventoryTransferSetItems` mutation.
/// </summary>
public record InventoryTransferSetItemsPayload : IGraphQLObject
{
    /// <summary>
    /// The Transfer with its line items updated.
    /// </summary>
    [JsonPropertyName("inventoryTransfer")]
    public InventoryTransfer? inventoryTransfer { get; set; } = null;

    /// <summary>
    /// The updated line items.
    /// </summary>
    [JsonPropertyName("updatedLineItems")]
    public ICollection<InventoryTransferLineItemUpdate>? updatedLineItems { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryTransferSetItemsUserError>? userErrors { get; set; } = null;
}