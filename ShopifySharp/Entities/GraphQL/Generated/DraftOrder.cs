#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An order that a merchant creates on behalf of a customer. Draft orders are
/// useful for merchants that need to do the following tasks:
/// - Create new orders for sales made by phone, in person, by chat, or elsewhere.
/// When a merchant accepts payment for a draft order, an order is created.
/// - Send invoices to customers to pay with a secure checkout link.
/// - Use custom items to represent additional costs or products that aren't displayed in a shop's inventory.
/// - Re-create orders manually from active sales channels.
/// - Sell products at discount or wholesale rates.
/// - Take pre-orders.
/// For draft orders in multiple currencies `presentment_money` is the source of
/// truth for what a customer is going to be charged and `shop_money` is an estimate
/// of what the merchant might receive in their shop currency.
/// **Caution:** Only use this data if it's required for your app's functionality.
/// Shopify will restrict [access to
/// scopes](https://shopify.dev/api/usage/access-scopes) for apps that don't have a
/// legitimate use for the associated data.
/// Draft orders created on or after April 1, 2025 will be automatically purged after one year of inactivity.
/// </summary>
public record DraftOrder : IGraphQLUnionCase, IGraphQLObject, ICommentEventSubject, IHasEvents, IHasLocalizationExtensions, IHasLocalizedFields, IHasMetafields, ILegacyInteroperability, INavigable, INode
{
    /// <summary>
    /// Whether or not to accept automatic discounts on the draft order during calculation.
    /// If false, only discount codes and custom draft order discounts (see `appliedDiscount`) will be applied.
    /// If true, eligible automatic discounts will be applied in addition to discount codes and custom draft order discounts.
    /// </summary>
    [JsonPropertyName("acceptAutomaticDiscounts")]
    public bool? acceptAutomaticDiscounts { get; set; } = null;

    /// <summary>
    /// Whether discount codes are allowed during checkout of this draft order.
    /// </summary>
    [JsonPropertyName("allowDiscountCodesInCheckout")]
    public bool? allowDiscountCodesInCheckout { get; set; } = null;

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
    /// The billing address of the customer.
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public MailingAddress? billingAddress { get; set; } = null;

    /// <summary>
    /// Whether the billing address matches the shipping address.
    /// </summary>
    [JsonPropertyName("billingAddressMatchesShippingAddress")]
    public bool? billingAddressMatchesShippingAddress { get; set; } = null;

    /// <summary>
    /// The date and time when the draft order was converted to a new order,
    /// and had it's status changed to **Completed**.
    /// </summary>
    [JsonPropertyName("completedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? completedAt { get; set; } = null;

    /// <summary>
    /// The date and time when the draft order was created in Shopify.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The shop currency used for calculation.
    /// </summary>
    [JsonPropertyName("currencyCode")]
    public CurrencyCode? currencyCode { get; set; } = null;

    /// <summary>
    /// The custom information added to the draft order on behalf of the customer.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<Attribute>? customAttributes { get; set; } = null;

    /// <summary>
    /// The customer who will be sent an invoice.
    /// </summary>
    [JsonPropertyName("customer")]
    public Customer? customer { get; set; } = null;

    /// <summary>
    /// A default [cursor](https://shopify.dev/api/usage/pagination-graphql) that
    /// returns the single next record, sorted ascending by ID.
    /// </summary>
    [JsonPropertyName("defaultCursor")]
    public string? defaultCursor { get; set; } = null;

    /// <summary>
    /// All discount codes applied.
    /// </summary>
    [JsonPropertyName("discountCodes")]
    public ICollection<string>? discountCodes { get; set; } = null;

    /// <summary>
    /// The email address of the customer, which is used to send notifications.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// The list of events associated with the draft order.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// Whether the merchant has added timeline comments to the draft order.
    /// </summary>
    [JsonPropertyName("hasTimelineComment")]
    public bool? hasTimelineComment { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The subject defined for the draft invoice email template.
    /// </summary>
    [JsonPropertyName("invoiceEmailTemplateSubject")]
    public string? invoiceEmailTemplateSubject { get; set; } = null;

    /// <summary>
    /// The date and time when the invoice was last emailed to the customer.
    /// </summary>
    [JsonPropertyName("invoiceSentAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? invoiceSentAt { get; set; } = null;

    /// <summary>
    /// The link to the checkout, which is sent to the customer in the invoice email.
    /// </summary>
    [JsonPropertyName("invoiceUrl")]
    public string? invoiceUrl { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The list of the line items in the draft order.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public DraftOrderLineItemConnection? lineItems { get; set; } = null;

    /// <summary>
    /// A subtotal of the line items and corresponding discounts,
    /// excluding include shipping charges, shipping discounts, taxes, or order discounts.
    /// </summary>
    [JsonPropertyName("lineItemsSubtotalPrice")]
    public MoneyBag? lineItemsSubtotalPrice { get; set; } = null;

    /// <summary>
    /// List of localization extensions for the resource.
    /// </summary>
    [JsonPropertyName("localizationExtensions")]
    [Obsolete("This connection will be removed in a future version. Use `localizedFields` instead.")]
    public LocalizationExtensionConnection? localizationExtensions { get; set; } = null;

    /// <summary>
    /// List of localized fields for the resource.
    /// </summary>
    [JsonPropertyName("localizedFields")]
    public LocalizedFieldConnection? localizedFields { get; set; } = null;

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
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    public Metafield? metafield { get; set; } = null;

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// The identifier for the draft order, which is unique within the store. For example, _#D1223_.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The text from an optional note attached to the draft order.
    /// </summary>
    [JsonPropertyName("note2")]
    public string? note2 { get; set; } = null;

    /// <summary>
    /// The order that was created from the draft order.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// The associated payment terms for this draft order.
    /// </summary>
    [JsonPropertyName("paymentTerms")]
    public PaymentTerms? paymentTerms { get; set; } = null;

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
    /// The purchase order number.
    /// </summary>
    [JsonPropertyName("poNumber")]
    public string? poNumber { get; set; } = null;

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
    /// Whether the draft order is ready and can be completed.
    /// Draft orders might have asynchronous operations that can take time to finish.
    /// </summary>
    [JsonPropertyName("ready")]
    public bool? ready { get; set; } = null;

    /// <summary>
    /// The time after which inventory will automatically be restocked.
    /// </summary>
    [JsonPropertyName("reserveInventoryUntil")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? reserveInventoryUntil { get; set; } = null;

    /// <summary>
    /// The shipping address of the customer.
    /// </summary>
    [JsonPropertyName("shippingAddress")]
    public MailingAddress? shippingAddress { get; set; } = null;

    /// <summary>
    /// The line item containing the shipping information and costs.
    /// </summary>
    [JsonPropertyName("shippingLine")]
    public ShippingLine? shippingLine { get; set; } = null;

    /// <summary>
    /// The status of the draft order.
    /// </summary>
    [JsonPropertyName("status")]
    public DraftOrderStatus? status { get; set; } = null;

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
    /// The comma separated list of tags associated with the draft order.
    /// Updating `tags` overwrites any existing tags that were previously added to the draft order.
    /// To add new tags without overwriting existing tags, use the
    /// [tagsAdd](https://shopify.dev/api/admin-graphql/latest/mutations/tagsadd) mutation.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;

    /// <summary>
    /// Whether the line item prices include taxes.
    /// </summary>
    [JsonPropertyName("taxesIncluded")]
    public bool? taxesIncluded { get; set; } = null;

    /// <summary>
    /// Whether the draft order is tax exempt.
    /// </summary>
    [JsonPropertyName("taxExempt")]
    public bool? taxExempt { get; set; } = null;

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
    /// The total weight in grams of the draft order.
    /// </summary>
    [JsonPropertyName("totalWeight")]
    public ulong? totalWeight { get; set; } = null;

    /// <summary>
    /// Fingerprint of the current cart.
    /// In order to have bundles work, the fingerprint must be passed to
    /// each request as it was previously returned, unmodified.
    /// </summary>
    [JsonPropertyName("transformerFingerprint")]
    public string? transformerFingerprint { get; set; } = null;

    /// <summary>
    /// The date and time when the draft order was last changed.
    /// The format is YYYY-MM-DD HH:mm:ss. For example, 2016-02-05 17:04:01.
    /// </summary>
    [JsonPropertyName("updatedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? updatedAt { get; set; } = null;

    /// <summary>
    /// Whether the draft order will be visible to the customer on the self-serve portal.
    /// </summary>
    [JsonPropertyName("visibleToCustomer")]
    public bool? visibleToCustomer { get; set; } = null;

    /// <summary>
    /// The list of warnings raised while calculating.
    /// </summary>
    [JsonPropertyName("warnings")]
    public ICollection<IDraftOrderWarning>? warnings { get; set; } = null;
}