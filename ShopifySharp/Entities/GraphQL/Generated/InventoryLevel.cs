#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The quantities of an inventory item that are related to a specific location.
/// Learn [more about the relationships between inventory objects](https://shopify.dev/docs/apps/build/orders-fulfillment/inventory-management-apps/manage-quantities-states#inventory-object-relationships).
/// </summary>
public record InventoryLevel : IGraphQLObject, INode
{
    /// <summary>
    /// Whether the inventory items associated with the inventory level can be deactivated.
    /// </summary>
    [JsonPropertyName("canDeactivate")]
    public bool? canDeactivate { get; set; } = null;

    /// <summary>
    /// The date and time when the inventory level was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// Describes either the impact of deactivating the inventory level, or why the inventory level can't be deactivated.
    /// </summary>
    [JsonPropertyName("deactivationAlert")]
    public string? deactivationAlert { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Inventory item associated with the inventory level.
    /// </summary>
    [JsonPropertyName("item")]
    public InventoryItem? item { get; set; } = null;

    /// <summary>
    /// The location associated with the inventory level.
    /// </summary>
    [JsonPropertyName("location")]
    public Location? location { get; set; } = null;

    /// <summary>
    /// Quantities for the requested names.
    /// </summary>
    [JsonPropertyName("quantities")]
    public ICollection<InventoryQuantity>? quantities { get; set; } = null;

    /// <summary>
    /// Scheduled changes for the requested quantity names.
    /// </summary>
    [JsonPropertyName("scheduledChanges")]
    public InventoryScheduledChangeConnection? scheduledChanges { get; set; } = null;

    /// <summary>
    /// The date and time when the inventory level was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;
}