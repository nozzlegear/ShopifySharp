#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to remove inventory items from a transfer.
/// </summary>
public record InventoryTransferRemoveItemsInput : GraphQLInputObject<InventoryTransferRemoveItemsInput>
{
    /// <summary>
    /// The ID of the inventory transfer where the items will be removed.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The IDs of the transfer line items to be removed from the transfer.
    /// </summary>
    [JsonPropertyName("transferLineItemIds")]
    public ICollection<string>? transferLineItemIds { get; set; } = null;
}