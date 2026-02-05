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
/// Records a batch of inventory changes made together in a single operation. Tracks
/// which [`App`](https://shopify.dev/docs/api/admin-graphql/latest/objects/App) or [`StaffMember`](https://shopify.dev/docs/api/admin-graphql/latest/objects/StaffMember)
/// initiated the changes, when they occurred, and why they were made.
/// Provides an audit trail through its reason and reference document URI. The
/// reference document URI links to the source that triggered the adjustment, such as
/// an [`Order`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Order), [`InventoryTransfer`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryTransfer),
/// or external system event. Use the [`changes`](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryAdjustmentGroup#field-InventoryAdjustmentGroup.fields.changes)
/// field to retrieve the specific quantity adjustments for each inventory state at affected
/// [locations](https://shopify.dev/docs/api/admin-graphql/latest/objects/Location).
/// </summary>
public record InventoryAdjustmentGroup : IGraphQLObject, INode
{
    /// <summary>
    /// The app that triggered the inventory event, if one exists.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The set of inventory quantity changes that occurred in the inventory event.
    /// </summary>
    [JsonPropertyName("changes")]
    public ICollection<InventoryChange>? changes { get; set; } = null;

    /// <summary>
    /// The date and time the inventory adjustment group was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The reason for the group of adjustments.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? reason { get; set; } = null;

    /// <summary>
    /// A freeform URI that represents why the inventory change happened. This can be the entity adjusting inventory
    /// quantities or the Shopify resource that's associated with the inventory adjustment. For example, a unit in a
    /// draft order might have been previously reserved, and a merchant later creates an order from the draft order.
    /// In this case, the `referenceDocumentUri` for the inventory adjustment is a URI referencing the order ID.
    /// </summary>
    [JsonPropertyName("referenceDocumentUri")]
    public string? referenceDocumentUri { get; set; } = null;

    /// <summary>
    /// The staff member associated with the inventory event.
    /// </summary>
    [JsonPropertyName("staffMember")]
    public StaffMember? staffMember { get; set; } = null;
}