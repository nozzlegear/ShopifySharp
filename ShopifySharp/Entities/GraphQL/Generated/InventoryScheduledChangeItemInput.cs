#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the inventory item associated with the scheduled changes that need to be applied.
/// </summary>
public record InventoryScheduledChangeItemInput : GraphQLInputObject<InventoryScheduledChangeItemInput>
{
    /// <summary>
    /// The ID of the inventory item.
    /// </summary>
    [JsonPropertyName("inventoryItemId")]
    public string? inventoryItemId { get; set; } = null;

    /// <summary>
    /// A non-Shopify URI that identifies what specific inventory transaction or
    /// ledger entry was changed. Represents the exact inventory movement being
    /// referenced, distinct from the business reason for the change.
    /// Preferred format - Global ID (GID): gid://[your-app-name]/[transaction-type]/[id]
    /// Examples:
    /// - gid://warehouse-app/InventoryTransaction/TXN-2024-001 (specific transaction)
    /// - gid://3pl-system/StockMovement/SM-2024-0125 (stock movement record)
    /// - gid://pos-app/InventoryUpdate/UPD-98765 (POS inventory update)
    /// - gid://erp-connector/LedgerEntry/LE-2024-11-21-001 (ledger entry)
    /// Requirements: Valid non-Shopify URI with scheme and content. Cannot use gid://shopify/* format.
    /// </summary>
    [JsonPropertyName("ledgerDocumentUri")]
    public string? ledgerDocumentUri { get; set; } = null;

    /// <summary>
    /// The ID of the location.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;

    /// <summary>
    /// An array of all the scheduled changes for the item.
    /// </summary>
    [JsonPropertyName("scheduledChanges")]
    public ICollection<InventoryScheduledChangeInput>? scheduledChanges { get; set; } = null;
}