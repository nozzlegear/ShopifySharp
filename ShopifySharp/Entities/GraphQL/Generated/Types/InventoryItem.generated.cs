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
/// A [product variant's](https://shopify.dev/docs/api/admin-graphql/latest/objects/ProductVariant) inventory information across all locations. The inventory item connects the
/// product variant to its [inventory levels](https://shopify.dev/docs/api/admin-graphql/latest/objects/InventoryLevel)
/// at different locations, tracking stock keeping unit (SKU), whether quantities
/// are tracked, shipping requirements, and customs information for the product.
/// Learn more about [inventory object relationships](https://shopify.dev/docs/apps/build/orders-fulfillment/inventory-management-apps/manage-quantities-states#inventory-object-relationships).
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
    public DateTimeOffset? createdAt { get; set; } = null;

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
    public DateTimeOffset? updatedAt { get; set; } = null;

    /// <summary>
    /// The variant that owns this inventory item.
    /// </summary>
    [JsonPropertyName("variant")]
    [Obsolete("Use `variants` instead.")]
    public ProductVariant? variant { get; set; } = null;

    /// <summary>
    /// A paginated list of the variants that reference this inventory item.
    /// </summary>
    [JsonPropertyName("variants")]
    public ProductVariantConnection? variants { get; set; } = null;
}