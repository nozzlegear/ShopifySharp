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
/// A change in an inventory quantity of an inventory item at a location. Each
/// change tracks how inventory moves between different states like available,
/// committed, reserved, or damaged.
/// The change captures the [amount changed](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryChange#field-InventoryChange.fields.delta), the resulting [quantity](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryChange#field-InventoryChange.fields.quantityAfterChange),
/// and links to the associated [`InventoryItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryItem) and [`Location`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location).
/// The [`name`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryChange#field-InventoryChange.fields.name) field indicates which inventory state changed, such as `available`, `reserved`,
/// or `damaged`. The [`ledgerDocumentUri`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryChange#field-InventoryChange.fields.ledgerDocumentUri)
/// field provides an audit trail by referencing the source document or system that
/// triggered the change.
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