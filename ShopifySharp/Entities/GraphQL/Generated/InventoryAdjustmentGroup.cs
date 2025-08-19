#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a group of adjustments made as part of the same operation.
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
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

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