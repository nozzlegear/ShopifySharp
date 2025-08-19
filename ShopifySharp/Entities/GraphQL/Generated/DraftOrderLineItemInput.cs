#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a line item included in a draft order.
/// </summary>
public record DraftOrderLineItemInput : GraphQLInputObject<DraftOrderLineItemInput>
{
    /// <summary>
    /// The custom discount to be applied.
    /// </summary>
    [JsonPropertyName("appliedDiscount")]
    public DraftOrderAppliedDiscountInput? appliedDiscount { get; set; } = null;

    /// <summary>
    /// The components of the draft order line item.
    /// </summary>
    [JsonPropertyName("components")]
    public ICollection<DraftOrderLineItemComponentInput>? components { get; set; } = null;

    /// <summary>
    /// A generic custom attribute using a key value pair.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<AttributeInput>? customAttributes { get; set; } = null;

    /// <summary>
    /// If the line item doesn't already have a price override input, setting `generatePriceOverride` to `true` will
    /// create a price override from the current price.
    /// </summary>
    [JsonPropertyName("generatePriceOverride")]
    public bool? generatePriceOverride { get; set; } = null;

    /// <summary>
    /// The price in presentment currency, without any discounts applied, for a custom line item.
    /// If this value is provided, `original_unit_price` will be ignored. This field is ignored when `variantId` is provided.
    /// Note: All presentment currencies for a single draft should be the same and match the
    /// presentment currency of the draft order.
    /// </summary>
    [JsonPropertyName("originalUnitPriceWithCurrency")]
    public MoneyInput? originalUnitPriceWithCurrency { get; set; } = null;

    /// <summary>
    /// The price override for the line item. Should be set in presentment currency.
    /// This price will be used in place of the product variant's catalog price in this draft order.
    /// If the override's presentment currency doesn't match the draft order's presentment currency, it will be
    /// converted over to match the draft order's presentment currency. This will occur if the input is defined in a
    /// differing currency, or if some other event causes the draft order's currency to change.
    /// Price overrides can't be applied to bundle components. If this line item becomes part of a bundle the price
    /// override will be removed. In the case of a cart transform, this may mean that a price override is applied to
    /// this line item earlier in its lifecycle, and is removed later when the transform occurs.
    /// </summary>
    [JsonPropertyName("priceOverride")]
    public MoneyInput? priceOverride { get; set; } = null;

    /// <summary>
    /// The line item quantity.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// Whether physical shipping is required for a custom line item. This field is ignored when `variantId` is provided.
    /// </summary>
    [JsonPropertyName("requiresShipping")]
    public bool? requiresShipping { get; set; } = null;

    /// <summary>
    /// The SKU number for custom line items only. This field is ignored when `variantId` is provided.
    /// </summary>
    [JsonPropertyName("sku")]
    public string? sku { get; set; } = null;

    /// <summary>
    /// Whether the custom line item is taxable. This field is ignored when `variantId` is provided.
    /// </summary>
    [JsonPropertyName("taxable")]
    public bool? taxable { get; set; } = null;

    /// <summary>
    /// Title of the line item. This field is ignored when `variantId` is provided.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The UUID of the draft order line item. Must be unique and consistent across requests.
    /// This field is mandatory in order to manipulate drafts with bundles.
    /// </summary>
    [JsonPropertyName("uuid")]
    public string? uuid { get; set; } = null;

    /// <summary>
    /// The ID of the product variant corresponding to the line item.
    /// Must be null for custom line items, otherwise required.
    /// </summary>
    [JsonPropertyName("variantId")]
    public string? variantId { get; set; } = null;

    /// <summary>
    /// The weight unit and value inputs for custom line items only.
    /// This field is ignored when `variantId` is provided.
    /// </summary>
    [JsonPropertyName("weight")]
    public WeightInput? weight { get; set; } = null;
}