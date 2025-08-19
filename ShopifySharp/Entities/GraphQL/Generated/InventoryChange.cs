#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a change in an inventory quantity of an inventory item at a location.
/// </summary>
public record InventoryChange : IGraphQLObject
{
    /// <summary>
    /// The amount by which the inventory quantity was changed.
    /// </summary>
    [JsonPropertyName("delta")]
    public int? delta { get; set; } = null;

    /// <summary>
    /// The inventory item associated with this inventory change.
    /// </summary>
    [JsonPropertyName("item")]
    public InventoryItem? item { get; set; } = null;

    /// <summary>
    /// A URI that represents what the inventory quantity change was applied to.
    /// </summary>
    [JsonPropertyName("ledgerDocumentUri")]
    public string? ledgerDocumentUri { get; set; } = null;

    /// <summary>
    /// The location associated with this inventory change.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// The [name](https://shopify.dev/docs/apps/fulfillment/inventory-management-apps#inventory-states)
    /// of the inventory quantity that was changed.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The quantity of named inventory after the change.
    /// </summary>
    [JsonPropertyName("quantityAfterChange")]
    public int? quantityAfterChange { get; set; } = null;
}