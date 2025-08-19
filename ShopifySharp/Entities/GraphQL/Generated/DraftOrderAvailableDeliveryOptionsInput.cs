#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to determine available delivery options for a draft order.
/// </summary>
public record DraftOrderAvailableDeliveryOptionsInput : GraphQLInputObject<DraftOrderAvailableDeliveryOptionsInput>
{
    /// <summary>
    /// Whether or not to accept automatic discounts on the draft order during calculation.
    /// If false, only discount codes and custom draft order discounts (see `appliedDiscount`) will be applied.
    /// If true, eligible automatic discounts will be applied in addition to discount codes and custom draft order discounts.
    /// </summary>
    [JsonPropertyName("acceptAutomaticDiscounts")]
    public bool? acceptAutomaticDiscounts { get; set; } = null;

    /// <summary>
    /// The discount that will be applied to the draft order.
    /// A draft order line item can have one discount. A draft order can also have one order-level discount.
    /// </summary>
    [JsonPropertyName("appliedDiscount")]
    public DraftOrderAppliedDiscountInput? appliedDiscount { get; set; } = null;

    /// <summary>
    /// Discount codes that will be attempted to be applied to the draft order. If the
    /// draft isn't eligible for any given discount code it will be skipped during calculation.
    /// </summary>
    [JsonPropertyName("discountCodes")]
    public ICollection<string>? discountCodes { get; set; } = null;

    /// <summary>
    /// Product variant line item or custom line item associated to the draft order.
    /// Each draft order must include at least one line item.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ICollection<DraftOrderLineItemInput>? lineItems { get; set; } = null;

    /// <summary>
    /// The selected country code that determines the pricing of the draft order.
    /// </summary>
    [JsonPropertyName("marketRegionCountryCode")]
    public CountryCode? marketRegionCountryCode { get; set; } = null;

    /// <summary>
    /// The purchasing entity for the draft order.
    /// </summary>
    [JsonPropertyName("purchasingEntity")]
    public PurchasingEntityInput? purchasingEntity { get; set; } = null;

    /// <summary>
    /// The mailing address to where the order will be shipped.
    /// </summary>
    [JsonPropertyName("shippingAddress")]
    public MailingAddressInput? shippingAddress { get; set; } = null;
}