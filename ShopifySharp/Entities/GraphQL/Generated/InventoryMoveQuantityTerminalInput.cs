#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields representing the change to be made to an inventory item at a location.
/// </summary>
public record InventoryMoveQuantityTerminalInput : GraphQLInputObject<InventoryMoveQuantityTerminalInput>
{
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
    /// Requirements: Valid non-Shopify URI with scheme and content. Required for all
    /// quantity names except `available`. Cannot use gid://shopify/* format.
    /// </summary>
    [JsonPropertyName("ledgerDocumentUri")]
    public string? ledgerDocumentUri { get; set; } = null;

    /// <summary>
    /// Specifies the location at which the change will be applied.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;

    /// <summary>
    /// The quantity
    /// [name](https://shopify.dev/docs/apps/fulfillment/inventory-management-apps#inventory-states) to be
    /// moved.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}