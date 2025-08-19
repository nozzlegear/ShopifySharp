#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for an inventory item.
/// </summary>
public record InventoryItemInput : GraphQLInputObject<InventoryItemInput>
{
    /// <summary>
    /// Unit cost associated with the inventory item, the currency is the shop's default currency.
    /// </summary>
    [JsonPropertyName("cost")]
    public decimal? cost { get; set; } = null;

    /// <summary>
    /// The country where the item was manufactured or produced, specified using the
    /// standard two-letter [ISO 3166-1
    /// alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code.
    /// </summary>
    [JsonPropertyName("countryCodeOfOrigin")]
    public CountryCode? countryCodeOfOrigin { get; set; } = null;

    /// <summary>
    /// List of country-specific harmonized system codes.
    /// </summary>
    [JsonPropertyName("countryHarmonizedSystemCodes")]
    public ICollection<CountryHarmonizedSystemCodeInput>? countryHarmonizedSystemCodes { get; set; } = null;

    /// <summary>
    /// The harmonized system code of the inventory item. This must be a number between 6 and 13 digits.
    /// </summary>
    [JsonPropertyName("harmonizedSystemCode")]
    public string? harmonizedSystemCode { get; set; } = null;

    /// <summary>
    /// The measurements of an inventory item.
    /// </summary>
    [JsonPropertyName("measurement")]
    public InventoryItemMeasurementInput? measurement { get; set; } = null;

    /// <summary>
    /// The province where the item was manufactured or produced, specified using the
    /// standard two-letter [ISO 3166-2
    /// alpha-2](https://en.wikipedia.org/wiki/ISO_3166-2) province code.
    /// </summary>
    [JsonPropertyName("provinceCodeOfOrigin")]
    public string? provinceCodeOfOrigin { get; set; } = null;

    /// <summary>
    /// Whether the inventory item needs to be physically shipped to the customer.
    /// Items that require shipping are physical products, while digital goods and
    /// services typically don't require shipping and can be fulfilled electronically.
    /// </summary>
    [JsonPropertyName("requiresShipping")]
    public bool? requiresShipping { get; set; } = null;

    /// <summary>
    /// The SKU (stock keeping unit) of the inventory item.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;

    /// <summary>
    /// Whether the inventory item is tracked.
    /// </summary>
    [JsonPropertyName("tracked")]
    public bool? tracked { get; set; } = null;
}