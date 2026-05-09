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
    /// The IDs of the [`InventoryTransferLineItem`s](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryTransferLineItem)
    /// to be removed from the transfer. Passing an empty array is a no-op and returns
    /// the transfer unchanged.
    /// </summary>
    [JsonPropertyName("transferLineItemIds")]
    public ICollection<string>? transferLineItemIds { get; set; } = null;
}