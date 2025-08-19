#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The calculated fields for a draft order.
/// </summary>
public record CalculatedDraftOrder : IGraphQLObject
{
    /// <summary>
    /// Whether or not to accept automatic discounts on the draft order during calculation.
    /// If false, only discount codes and custom draft order discounts (see `appliedDiscount`) will be applied.
    /// If true, eligible automatic discounts will be applied in addition to discount codes and custom draft order discounts.
    /// </summary>
    [JsonPropertyName("acceptAutomaticDiscounts")]
    public bool? acceptAutomaticDiscounts { get; set; } = null;

    /// <summary>
    /// The list of alerts raised while calculating.
    /// </summary>
    [JsonPropertyName("alerts")]
    public ICollection<ResourceAlert>? alerts { get; set; } = null;

    /// <summary>
    /// Whether all variant prices have been overridden.
    /// </summary>
    [JsonPropertyName("allVariantPricesOverridden")]
    public bool? allVariantPricesOverridden { get; set; } = null;

    /// <summary>
    /// Whether any variant prices have been overridden.
    /// </summary>
    [JsonPropertyName("anyVariantPricesOverridden")]
    public bool? anyVariantPricesOverridden { get; set; } = null;

    /// <summary>
    /// The custom order-level discount applied.
    /// </summary>
    [JsonPropertyName("appliedDiscount")]
    public DraftOrderAppliedDiscount? appliedDiscount { get; set; } = null;

    /// <summary>
    /// The available shipping rates.
    /// Requires a customer with a valid shipping address and at least one line item.
    /// </summary>
    [JsonPropertyName("availableShippingRates")]
    public ICollection<ShippingRate>? availableShippingRates { get; set; } = null;

    /// <summary>
    /// Whether the billing address matches the shipping address.
    /// </summary>
    [JsonPropertyName("billingAddressMatchesShippingAddress")]
    public bool? billingAddressMatchesShippingAddress { get; set; } = null;

    /// <summary>
    /// The shop currency used for calculation.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public CurrencyCode? currencyCode { get; set; } = null;

    /// <summary>
    /// The customer who will be sent an invoice.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; } = null;

    /// <summary>
    /// All discount codes applied.
    /// </summary>
    [JsonPropertyName("discountCodes")]
    public ICollection<string>? discountCodes { get; set; } = null;

    /// <summary>
    /// The list of the line items in the calculated draft order.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ICollection<CalculatedDraftOrderLineItem>? lineItems { get; set; } = null;

    /// <summary>
    /// A subtotal of the line items and corresponding discounts,
    /// excluding include shipping charges, shipping discounts, taxes, or order discounts.
    /// </summary>
    [JsonPropertyName("lineItemsSubtotalPrice")]
    public MoneyBag? lineItemsSubtotalPrice { get; set; } = null;

    /// <summary>
    /// The name of the selected market.
    /// </summary>
    [JsonPropertyName("marketName")]
    [Obsolete("This field is now incompatible with Markets.")]
    public string? marketName { get; set; } = null;

    /// <summary>
    /// The selected country code that determines the pricing.
    /// </summary>
    [JsonPropertyName("marketRegionCountryCode")]
    [Obsolete("This field is now incompatible with Markets.")]
    public CountryCode? marketRegionCountryCode { get; set; } = null;

    /// <summary>
    /// The assigned phone number.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The list of platform discounts applied.
    /// </summary>
    [JsonPropertyName("platformDiscounts")]
    public ICollection<DraftOrderPlatformDiscount>? platformDiscounts { get; set; } = null;

    /// <summary>
    /// The payment currency used for calculation.
    /// </summary>
    [JsonPropertyName("presentmentCurrencyCode")]
    public CurrencyCode? presentmentCurrencyCode { get; set; } = null;

    /// <summary>
    /// The purchasing entity.
    /// </summary>
    [JsonPropertyName("purchasingEntity")]
    public PurchasingEntity? purchasingEntity { get; set; } = null;

    /// <summary>
    /// The line item containing the shipping information and costs.
    /// </summary>
    [JsonPropertyName("shippingLine")]
    public ShippingLine? shippingLine { get; set; } = null;

    /// <summary>
    /// The subtotal, in shop currency, of the line items and their discounts,
    /// excluding shipping charges, shipping discounts, and taxes.
    /// </summary>
    [JsonPropertyName("subtotalPrice")]
    [Obsolete("Use `subtotalPriceSet` instead.")]
    public decimal? subtotalPrice { get; set; } = null;

    /// <summary>
    /// The subtotal, of the line items and their discounts, excluding shipping charges, shipping discounts, and taxes.
    /// </summary>
    [JsonPropertyName("subtotalPriceSet")]
    public MoneyBag? subtotalPriceSet { get; set; } = null;

    /// <summary>
    /// Whether the line item prices include taxes.
    /// </summary>
    [JsonPropertyName("taxesIncluded")]
    public bool? taxesIncluded { get; set; } = null;

    /// <summary>
    /// The list of of taxes lines charged for each line item and shipping line.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<TaxLine>? taxLines { get; set; } = null;

    /// <summary>
    /// Total discounts.
    /// </summary>
    [JsonPropertyName("totalDiscountsSet")]
    public MoneyBag? totalDiscountsSet { get; set; } = null;

    /// <summary>
    /// Total price of line items.
    /// </summary>
    [JsonPropertyName("totalLineItemsPriceSet")]
    public MoneyBag? totalLineItemsPriceSet { get; set; } = null;

    /// <summary>
    /// The total price, in shop currency, includes taxes, shipping charges, and discounts.
    /// </summary>
    [JsonPropertyName("totalPrice")]
    [Obsolete("Use `totalPriceSet` instead.")]
    public decimal? totalPrice { get; set; } = null;

    /// <summary>
    /// The total price, includes taxes, shipping charges, and discounts.
    /// </summary>
    [JsonPropertyName("totalPriceSet")]
    public MoneyBag? totalPriceSet { get; set; } = null;

    /// <summary>
    /// The sum of individual line item quantities.
    /// If the draft order has bundle items, this is the sum containing the quantities of individual items in the bundle.
    /// </summary>
    [JsonPropertyName("totalQuantityOfLineItems")]
    public int? totalQuantityOfLineItems { get; set; } = null;

    /// <summary>
    /// The total shipping price in shop currency.
    /// </summary>
    [JsonPropertyName("totalShippingPrice")]
    [Obsolete("Use `totalShippingPriceSet` instead.")]
    public decimal? totalShippingPrice { get; set; } = null;

    /// <summary>
    /// The total shipping price.
    /// </summary>
    [JsonPropertyName("totalShippingPriceSet")]
    public MoneyBag? totalShippingPriceSet { get; set; } = null;

    /// <summary>
    /// The total tax in shop currency.
    /// </summary>
    [JsonPropertyName("totalTax")]
    [Obsolete("Use `totalTaxSet` instead.")]
    public decimal? totalTax { get; set; } = null;

    /// <summary>
    /// The total tax.
    /// </summary>
    [JsonPropertyName("totalTaxSet")]
    public MoneyBag? totalTaxSet { get; set; } = null;

    /// <summary>
    /// Fingerprint of the current cart.
    /// In order to have bundles work, the fingerprint must be passed to
    /// each request as it was previously returned, unmodified.
    /// </summary>
    [JsonPropertyName("transformerFingerprint")]
    public string? transformerFingerprint { get; set; } = null;

    /// <summary>
    /// The list of warnings raised while calculating.
    /// </summary>
    [JsonPropertyName("warnings")]
    public ICollection<IDraftOrderWarning>? warnings { get; set; } = null;
}