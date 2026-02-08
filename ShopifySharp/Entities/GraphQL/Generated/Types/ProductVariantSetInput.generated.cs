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
/// The input fields for specifying a product variant to create or update.
/// </summary>
public record ProductVariantSetInput : GraphQLInputObject<ProductVariantSetInput>
{
    /// <summary>
    /// The value of the barcode associated with the product.
    /// </summary>
    [JsonPropertyName("barcode")]
    public string? barcode { get; set; } = null;

    /// <summary>
    /// The compare-at price of the variant.
    /// </summary>
    [JsonPropertyName("compareAtPrice")]
    public decimal? compareAtPrice { get; set; } = null;

    /// <summary>
    /// The file to associate with the variant.
    /// Complexity cost: 0.6 per variant file.
    /// Any file specified here must also be specified in the `files` input for the product.
    /// </summary>
    [JsonPropertyName("file")]
    public FileSetInput? file { get; set; } = null;

    /// <summary>
    /// Specifies the product variant to update or create a new variant if absent.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The inventory item associated with the variant, used for unit cost.
    /// </summary>
    [JsonPropertyName("inventoryItem")]
    public InventoryItemInput? inventoryItem { get; set; } = null;

    /// <summary>
    /// Whether customers are allowed to place an order for the product variant when it's out of stock. Defaults to `DENY`.
    /// </summary>
    [JsonPropertyName("inventoryPolicy")]
    public ProductVariantInventoryPolicy? inventoryPolicy { get; set; } = null;

    /// <summary>
    /// The inventory quantities at each location where the variant is stocked.
    /// If you're updating an existing variant, then you can only update the
    /// quantities at locations where the variant is already stocked.
    /// The total number of inventory quantities across all variants in the mutation can't exceed 50000.
    /// </summary>
    [JsonPropertyName("inventoryQuantities")]
    public ICollection<ProductSetInventoryInput>? inventoryQuantities { get; set; } = null;

    /// <summary>
    /// Additional customizable information about the product variant.
    /// Complexity cost: 0.4 per variant metafield.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The custom properties that a shop owner uses to define product variants.
    /// </summary>
    [JsonPropertyName("optionValues")]
    public ICollection<VariantOptionValueInput>? optionValues { get; set; } = null;

    /// <summary>
    /// The order of the product variant in the list of product variants. The first position in the list is 1.
    /// </summary>
    [JsonPropertyName("position")]
    public int? position { get; set; } = null;

    /// <summary>
    /// The price of the variant.
    /// </summary>
    [JsonPropertyName("price")]
    public decimal? price { get; set; } = null;

    /// <summary>
    /// Whether a product variant requires components. The default value is `false`.
    /// If `true`, then the product variant can only be purchased as a parent bundle with components and it will be omitted
    /// from channels that don't support bundles.
    /// </summary>
    [JsonPropertyName("requiresComponents")]
    public bool? requiresComponents { get; set; } = null;

    /// <summary>
    /// Whether or not unit price should be shown for this product variant.
    /// </summary>
    [JsonPropertyName("showUnitPrice")]
    public bool? showUnitPrice { get; set; } = null;

    /// <summary>
    /// The SKU for the variant. Case-sensitive string.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;

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