#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Returns the scheduled changes to inventory states related to the ledger document.
/// </summary>
public record InventoryScheduledChange : IGraphQLObject
{
    /// <summary>
    /// The date and time that the scheduled change is expected to happen.
    /// </summary>
    [JsonPropertyName("expectedAt")]
    public DateTime? expectedAt { get; set; } = null;

    /// <summary>
    /// The quantity
    /// [name](https://shopify.dev/docs/apps/fulfillment/inventory-management-apps/quantities-states#move-inventory-quantities-between-states)
    /// to transition from.
    /// </summary>
    [JsonPropertyName("fromName")]
    public string? fromName { get; set; } = null;

    /// <summary>
    /// The quantities of an inventory item that are related to a specific location.
    /// </summary>
    [JsonPropertyName("inventoryLevel")]
    public InventoryLevel? inventoryLevel { get; set; } = null;

    /// <summary>
    /// A freeform URI that represents what changed the inventory quantities.
    /// </summary>
    [JsonPropertyName("ledgerDocumentUri")]
    public string? ledgerDocumentUri { get; set; } = null;

    /// <summary>
    /// The quantity of the scheduled change associated with the ledger document in the `fromName` state.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The quantity
    /// [name](https://shopify.dev/docs/apps/fulfillment/inventory-management-apps/quantities-states#move-inventory-quantities-between-states)
    /// to transition to.
    /// </summary>
    [JsonPropertyName("toName")]
    public string? toName { get; set; } = null;
}