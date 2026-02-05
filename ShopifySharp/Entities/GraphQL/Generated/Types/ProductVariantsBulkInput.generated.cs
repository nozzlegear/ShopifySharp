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
/// The input fields for specifying a product variant to create as part of a variant bulk mutation.
/// </summary>
public record ProductVariantsBulkInput : GraphQLInputObject<ProductVariantsBulkInput>
{
    /// <summary>
    /// The value of the barcode associated with the product variant.
    /// </summary>
    [JsonPropertyName("barcode")]
    public string? barcode { get; set; } = null;

    /// <summary>
    /// The compare-at price of the variant.
    /// </summary>
    [JsonPropertyName("compareAtPrice")]
    public decimal? compareAtPrice { get; set; } = null;

    /// <summary>
    /// Specifies the product variant to update or delete.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The inventory item associated with the variant, used for unit cost.
    /// </summary>
    [JsonPropertyName("inventoryItem")]
    public InventoryItemInput? inventoryItem { get; set; } = null;

    /// <summary>
    /// Whether customers are allowed to place an order for the variant when it's out of stock. Defaults to `DENY`.
    /// </summary>
    [JsonPropertyName("inventoryPolicy")]
    public ProductVariantInventoryPolicy? inventoryPolicy { get; set; } = null;

    /// <summary>
    /// The inventory quantities at each location where the variant is stocked. The number of elements
    /// in the array of inventory quantities can't exceed the amount specified for the plan.
    /// Supported as input with the `productVariantsBulkCreate` mutation only.
    /// </summary>
    [JsonPropertyName("inventoryQuantities")]
    public ICollection<InventoryLevelInput>? inventoryQuantities { get; set; } = null;

    /// <summary>
    /// The ID of the media that's associated with the variant.
    /// </summary>
    [JsonPropertyName("mediaId")]
    public string? mediaId { get; set; } = null;

    /// <summary>
    /// The URL of the media to associate with the variant.
    /// </summary>
    [JsonPropertyName("mediaSrc")]
    public ICollection<string>? mediaSrc { get; set; } = null;

    /// <summary>
    /// The additional customizable information about the product variant.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The custom properties that a shop owner uses to define product variants.
    /// </summary>
    [JsonPropertyName("optionValues")]
    public ICollection<VariantOptionValueInput>? optionValues { get; set; } = null;

    /// <summary>
    /// The price of the variant.
    /// </summary>
    [JsonPropertyName("price")]
    public decimal? price { get; set; } = null;

    /// <summary>
    /// Adjust inventory quantities with deltas.
    /// </summary>
    [JsonPropertyName("quantityAdjustments")]
    public ICollection<InventoryAdjustmentInput>? quantityAdjustments { get; set; } = null;

    /// <summary>
    /// Whether a product variant requires components. The default value is `false`.
    /// If `true`, then the product variant can only be purchased as a parent bundle with components and it will be
    /// omitted from channels that don't support bundles.
    /// </summary>
    [JsonPropertyName("requiresComponents")]
    public bool? requiresComponents { get; set; } = null;

    /// <summary>
    /// Whether the unit price should be shown for this product variant.
    /// </summary>
    [JsonPropertyName("showUnitPrice")]
    public bool? showUnitPrice { get; set; } = null;

    /// <summary>
    /// Whether the variant is taxable.
    /// </summary>
    [JsonPropertyName("taxable")]
    public bool? taxable { get; set; } = null;

    /// <summary>
    /// The tax code associated with the variant.
    /// </summary>
    [JsonPropertyName("taxCode")]
    public string? taxCode { get; set; } = null;

    /// <summary>
    /// The unit price measurement for the product variant.
    /// </summary>
    [JsonPropertyName("unitPriceMeasurement")]
    public UnitPriceMeasurementInput? unitPriceMeasurement { get; set; } = null;
}