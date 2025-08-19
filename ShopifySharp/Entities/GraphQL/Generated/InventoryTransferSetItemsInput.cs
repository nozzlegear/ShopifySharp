#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

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
    /// The line items to be set on the Transfer.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ICollection<InventoryTransferLineItemInput>? lineItems { get; set; } = null;
}