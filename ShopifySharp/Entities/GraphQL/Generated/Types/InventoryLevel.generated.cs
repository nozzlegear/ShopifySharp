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
/// The quantities of an inventory item at a specific location. Each inventory level connects one [`InventoryItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryItem) to one [`Location`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location),
/// tracking multiple quantity states like available, on-hand, incoming, and committed.
/// The [`quantities`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryLevel#field-InventoryLevel.fields.quantities) field provides access to different inventory states. Learn [more about inventory states and relationships](https://shopify.dev/docs/apps/build/orders-fulfillment/inventory-management-apps/manage-quantities-states#inventory-object-relationships).
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
    public DateTimeOffset? createdAt { get; set; } = null;

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
    /// The quantity of an inventory item at a specific location, for a quantity
    /// [name](https://shopify.dev/docs/apps/fulfillment/inventory-management-apps#inventory-states).
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
    public DateTimeOffset? updatedAt { get; set; } = null;
}