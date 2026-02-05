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
/// The input fields used to create or update a draft order.
/// </summary>
public record DraftOrderInput : GraphQLInputObject<DraftOrderInput>
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
    /// The discount that will be applied to the draft order.
    /// A draft order line item can have one discount. A draft order can also have one order-level discount.
    /// </summary>
    [JsonPropertyName("appliedDiscount")]
    public DraftOrderAppliedDiscountInput? appliedDiscount { get; set; } = null;

    /// <summary>
    /// The mailing address associated with the payment method.
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public MailingAddressInput? billingAddress { get; set; } = null;

    /// <summary>
    /// The extra information added to the draft order on behalf of the customer.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<AttributeInput>? customAttributes { get; set; } = null;

    /// <summary>
    /// The list of discount codes that will be attempted to be applied to the draft order.
    /// If the draft isn't eligible for any given discount code it will be skipped during calculation.
    /// </summary>
    [JsonPropertyName("discountCodes")]
    public ICollection<string>? discountCodes { get; set; } = null;

    /// <summary>
    /// The customer's email address.
    /// </summary>
    [JsonPropertyName("email")]
    public string? email { get; set; } = null;

    /// <summary>
    /// The list of product variant or custom line item.
    /// Each draft order must include at least one line item.
    /// Accepts a maximum of 499 line items.
    /// NOTE: Draft orders don't currently support subscriptions.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public ICollection<DraftOrderLineItemInput>? lineItems { get; set; } = null;

    /// <summary>
    /// The localized fields attached to the draft order. For example, Tax IDs.
    /// </summary>
    [JsonPropertyName("localizedFields")]
    public ICollection<LocalizedFieldInput>? localizedFields { get; set; } = null;

    /// <summary>
    /// The list of metafields attached to the draft order. An existing metafield can not be used when creating a draft order.
    /// </summary>
    [JsonPropertyName("metafields")]
    public ICollection<MetafieldInput>? metafields { get; set; } = null;

    /// <summary>
    /// The text of an optional note that a shop owner can attach to the draft order.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The fields used to create payment terms.
    /// </summary>
    [JsonPropertyName("paymentTerms")]
    public PaymentTermsInput? paymentTerms { get; set; } = null;

    /// <summary>
    /// The customer's phone number.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? phone { get; set; } = null;

    /// <summary>
    /// The purchase order number.
    /// </summary>
    [JsonPropertyName("poNumber")]
    public string? poNumber { get; set; } = null;

    /// <summary>
    /// The payment currency of the customer for this draft order.
    /// </summary>
    [JsonPropertyName("presentmentCurrencyCode")]
    public CurrencyCode? presentmentCurrencyCode { get; set; } = null;

    /// <summary>
    /// The purchasing entity for the draft order.
    /// </summary>
    [JsonPropertyName("purchasingEntity")]
    public PurchasingEntityInput? purchasingEntity { get; set; } = null;

    /// <summary>
    /// The time after which inventory reservation will expire.
    /// </summary>
    [JsonPropertyName("reserveInventoryUntil")]
    public DateTimeOffset? reserveInventoryUntil { get; set; } = null;

    /// <summary>
    /// The unique token identifying the draft order.
    /// </summary>
    [JsonPropertyName("sessionToken")]
    public string? sessionToken { get; set; } = null;

    /// <summary>
    /// The mailing address to where the order will be shipped.
    /// </summary>
    [JsonPropertyName("shippingAddress")]
    public MailingAddressInput? shippingAddress { get; set; } = null;

    /// <summary>
    /// The shipping line object, which details the shipping method used.
    /// </summary>
    [JsonPropertyName("shippingLine")]
    public ShippingLineInput? shippingLine { get; set; } = null;

    /// <summary>
    /// The source of the checkout.
    /// To use this field for sales attribution, you must register the channels that your app is managing.
    /// You can register the channels that your app is managing by completing
    /// [this Google Form](https://docs.google.com/forms/d/e/1FAIpQLScmVTZRQNjOJ7RD738mL1lGeFjqKVe_FM2tO9xsm21QEo5Ozg/viewform?usp=sf_link).
    /// After you've submitted your request, you need to wait for your request to be processed by Shopify.
    /// You can find a list of your channels in the Partner Dashboard, in your app's Marketplace extension.
    /// You need to specify the handle as the `source_name` value in your request.
    /// The handle is the channel that the order was placed from.
    /// </summary>
    [JsonPropertyName("sourceName")]
    public string? sourceName { get; set; } = null;

    /// <summary>
    /// A comma separated list of tags that have been added to the draft order.
    /// </summary>
    [JsonPropertyName("tags")]
    public ICollection<string>? tags { get; set; } = null;

    /// <summary>
    /// Whether or not taxes are exempt for the draft order.
    /// If false, then Shopify will refer to the taxable field for each line item.
    /// If a customer is applied to the draft order, then Shopify will use the customer's tax exempt field instead.
    /// </summary>
    [JsonPropertyName("taxExempt")]
    public bool? taxExempt { get; set; } = null;

    /// <summary>
    /// Fingerprint to guarantee bundles are handled correctly.
    /// </summary>
    [JsonPropertyName("transformerFingerprint")]
    public string? transformerFingerprint { get; set; } = null;

    /// <summary>
    /// Whether to use the customer's default address.
    /// </summary>
    [JsonPropertyName("useCustomerDefaultAddress")]
    public bool? useCustomerDefaultAddress { get; set; } = null;

    /// <summary>
    /// Whether the draft order will be visible to the customer on the self-serve portal.
    /// </summary>
    [JsonPropertyName("visibleToCustomer")]
    public bool? visibleToCustomer { get; set; } = null;
}