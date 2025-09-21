#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the change to be made to an inventory item at a location.
/// </summary>
public record InventoryChangeInput : GraphQLInputObject<InventoryChangeInput>
{
    /// <summary>
    /// The amount by which the inventory quantity will be changed.
    /// </summary>
    [JsonPropertyName("delta")]
    public int? delta { get; set; } = null;

    /// <summary>
    /// Specifies the inventory item to which the change will be applied.
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
}