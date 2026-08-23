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
/// The input fields to the InventoryTransferSetItems mutation.
/// </summary>
public record InventoryTransferSetItemsInput : GraphQLInputObject<InventoryTransferSetItemsInput>
{
    /// <summary>
    /// The ID of the inventory transfer where the items will be set.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The line items to set on the Transfer. Only the items included in this list
    /// are affected; items already on the transfer that aren't referenced here will
    /// stay unchanged. Each inventory item may appear at most once in this list;
    /// duplicate `inventoryItemId` entries are rejected.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ICollection<InventoryTransferLineItemInput>? lineItems { get; set; } = null;
}