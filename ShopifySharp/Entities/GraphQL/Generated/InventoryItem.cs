#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the goods available to be shipped to a customer.
/// It holds essential information about the goods, including SKU and whether it is tracked.
/// Learn [more about the relationships between inventory objects](https://shopify.dev/docs/apps/build/orders-fulfillment/inventory-management-apps/manage-quantities-states#inventory-object-relationships).
/// </summary>
public record InventoryItem : IGraphQLObject, ILegacyInteroperability, INode
{
    /// <summary>
    /// The ISO 3166-1 alpha-2 country code of where the item originated from.
    /// </summary>
    [JsonPropertyName("countryCodeOfOrigin")]
    public CountryCode? countryCodeOfOrigin { get; set; } = null;

    /// <summary>
    /// A list of country specific harmonized system codes.
    /// </summary>
    [JsonPropertyName("countryHarmonizedSystemCodes")]
    public CountryHarmonizedSystemCodeConnection? countryHarmonizedSystemCodes { get; set; } = null;

    /// <summary>
    /// The date and time when the inventory item was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The number of inventory items that share the same SKU with this item.
    /// </summary>
    [JsonPropertyName("duplicateSkuCount")]
    public int? duplicateSkuCount { get; set; } = null;

    /// <summary>
    /// The harmonized system code of the item. This must be a number between 6 and 13 digits.
    /// </summary>
    [JsonPropertyName("harmonizedSystemCode")]
    public string? harmonizedSystemCode { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The URL that points to the inventory history for the item.
    /// </summary>
    [JsonPropertyName("inventoryHistoryUrl")]
    public string? inventoryHistoryUrl { get; set; } = null;

    /// <summary>
    /// The inventory item's quantities at the specified location.
    /// </summary>
    [JsonPropertyName("inventoryLevel")]
    public InventoryLevel? inventoryLevel { get; set; } = null;

    /// <summary>
    /// A list of the inventory item's quantities for each location that the inventory item can be stocked at.
    /// </summary>
    [JsonPropertyName("inventoryLevels")]
    public InventoryLevelConnection? inventoryLevels { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The number of locations where this inventory item is stocked.
    /// </summary>
    [JsonPropertyName("locationsCount")]
    public Count? locationsCount { get; set; } = null;

    /// <summary>
    /// The packaging dimensions of the inventory item.
    /// </summary>
    [JsonPropertyName("measurement")]
    public InventoryItemMeasurement? measurement { get; set; } = null;

    /// <summary>
    /// The ISO 3166-2 alpha-2 province code of where the item originated from.
    /// </summary>
    [JsonPropertyName("provinceCodeOfOrigin")]
    public string? provinceCodeOfOrigin { get; set; } = null;

    /// <summary>
    /// Whether the inventory item requires shipping.
    /// </summary>
    [JsonPropertyName("requiresShipping")]
    public bool? requiresShipping { get; set; } = null;

    /// <summary>
    /// Inventory item SKU. Case-sensitive string.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;

    /// <summary>
    /// Whether inventory levels are tracked for the item.
    /// </summary>
    [JsonPropertyName("tracked")]
    public bool? tracked { get; set; } = null;

    /// <summary>
    /// Whether the value of the `tracked` field for the inventory item can be changed.
    /// </summary>
    [JsonPropertyName("trackedEditable")]
    public EditableProperty? trackedEditable { get; set; } = null;

    /// <summary>
    /// Unit cost associated with the inventory item. Note: the user must have "View
    /// product costs" permission granted in order to access this field once product
    /// granular permissions are enabled.
    /// </summary>
    [JsonPropertyName("unitCost")]
    public MoneyV2? unitCost { get; set; } = null;

    /// <summary>
    /// The date and time when the inventory item was updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;

    /// <summary>
    /// The variant that owns this inventory item.
    /// </summary>
    [JsonPropertyName("variant")]
    public ProductVariant? variant { get; set; } = null;
}