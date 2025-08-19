#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to set inventory quantities.
/// </summary>
public record InventorySetQuantitiesInput : GraphQLInputObject<InventorySetQuantitiesInput>
{
    /// <summary>
    /// Skip the compare quantity check in the quantities field.
    /// </summary>
    [JsonPropertyName("ignoreCompareQuantity")]
    public bool? ignoreCompareQuantity { get; set; } = null;

    /// <summary>
    /// The name of quantities to be changed. The only accepted values are: `available` or `on_hand`.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The values to which each quantities will be set.
    /// </summary>
    [JsonPropertyName("quantities")]
    public ICollection<InventoryQuantityInput>? quantities { get; set; } = null;

    /// <summary>
    /// The reason for the quantity changes. The value must be one of the [possible
    /// reasons](https://shopify.dev/docs/apps/fulfillment/inventory-management-apps/quantities-states#set-inventory-quantities-on-hand).
    /// </summary>
    [JsonPropertyName("reason")]
    public string? reason { get; set; } = null;

    /// <summary>
    /// A URI that represents why the inventory change happened, identifying the
    /// source system and document that caused this adjustment. Enables complete audit
    /// trails and brand visibility in Shopify admin inventory history.
    /// Preferred format - Global ID (GID): gid://[your-app-name]/[entity-type]/[id]
    /// Examples:
    /// - gid://warehouse-app/PurchaseOrder/PO-2024-001 (stock received)
    /// - gid://3pl-system/CycleCount/CC-2024-0125 (cycle count adjustment)
    /// - gid://pos-app/Transaction/TXN-98765 (in-store sale)
    /// - gid://erp-connector/SyncJob/SYNC-2024-11-21-001 (ERP sync)
    /// - gid://shopify/Order/1234567890 (Shopify order reference)
    /// Benefits: Your app name appears directly in merchant inventory history,
    /// reducing support tickets and providing clear audit trails for compliance.
    /// Alternative formats (also supported): https://myapp.com/documents/12345, custom-scheme://identifier
    /// Requirements: Valid URI with scheme and content. For GID format, all components (app, entity, id) must be present.
    /// </summary>
    [JsonPropertyName("referenceDocumentUri")]
    public string? referenceDocumentUri { get; set; } = null;
}