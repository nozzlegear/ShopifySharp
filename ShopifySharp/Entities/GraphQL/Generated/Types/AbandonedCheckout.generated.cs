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
/// An incomplete checkout where the customer added items and provided contact
/// information but didn't complete the purchase. Tracks the customer's cart
/// contents, pricing details, addresses, and timestamps to enable recovery
/// campaigns and abandonment analytics.
/// The checkout includes a recovery URL that merchants can send to customers to
/// resume their purchase. [`AbandonedCheckoutLineItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/AbandonedCheckoutLineItem)
/// objects preserve the original
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
/// selections, quantities, and pricing at the time of abandonment.
/// </summary>
public record AbandonedCheckout : IGraphQLObject, INavigable, INode
{
    /// <summary>
    /// The URL for the buyer to recover their checkout.
    /// </summary>
    [JsonPropertyName("abandonedCheckoutUrl")]
    public string? abandonedCheckoutUrl { get; set; } = null;

    /// <summary>
    /// The billing address provided by the buyer.
    /// Null if the user did not provide a billing address.
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public MailingAddress? billingAddress { get; set; } = null;

    /// <summary>
    /// The date and time when the buyer completed the checkout.
    /// Null if the checkout has not been completed.
    /// </summary>
    [JsonPropertyName("completedAt")]
    public DateTimeOffset? completedAt { get; set; } = null;

    /// <summary>
    /// The date and time when the checkout was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; } = null;

    /// <summary>
    /// A list of extra information that has been added to the checkout.
    /// </summary>
    [JsonPropertyName("customAttributes")]
    public ICollection<Attribute>? customAttributes { get; set; } = null;

    /// <summary>
    /// The customer who created this checkout.
    /// May be null if the checkout was created from a draft order or via an app.
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
    /// The discount codes entered by the buyer at checkout.
    /// </summary>
    [JsonPropertyName("discountCodes")]
    public ICollection<string>? discountCodes { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// A list of the line items in this checkout.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public AbandonedCheckoutLineItemConnection? lineItems { get; set; } = null;

    /// <summary>
    /// The number of products in the checkout.
    /// </summary>
    [JsonPropertyName("lineItemsQuantity")]
    [Obsolete("Use [AbandonedCheckoutLineItem.quantity](https://shopify.dev/api/admin-graphql/unstable/objects/AbandonedCheckoutLineItem#field-quantity) instead.")]
    public int? lineItemsQuantity { get; set; } = null;

    /// <summary>
    /// Unique merchant-facing identifier for the checkout.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A merchant-facing note added to the checkout. Not visible to the buyer.
    /// </summary>
    [JsonPropertyName("note")]
    public string? note { get; set; } = null;

    /// <summary>
    /// The shipping address to where the line items will be shipped.
    /// Null if the user did not provide a shipping address.
    /// </summary>
    [JsonPropertyName("shippingAddress")]
    public MailingAddress? shippingAddress { get; set; } = null;

    /// <summary>
    /// The sum of all items in the checkout, including discounts but excluding shipping, taxes and tips.
    /// </summary>
    [JsonPropertyName("subtotalPriceSet")]
    public MoneyBag? subtotalPriceSet { get; set; } = null;

    /// <summary>
    /// Whether taxes are included in line item and shipping line prices.
    /// </summary>
    [JsonPropertyName("taxesIncluded")]
    public bool? taxesIncluded { get; set; } = null;

    /// <summary>
    /// Individual taxes charged on the checkout.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<TaxLine>? taxLines { get; set; } = null;

    /// <summary>
    /// The total amount of discounts to be applied.
    /// </summary>
    [JsonPropertyName("totalDiscountSet")]
    public MoneyBag? totalDiscountSet { get; set; } = null;

    /// <summary>
    /// The total duties applied to the checkout.
    /// </summary>
    [JsonPropertyName("totalDutiesSet")]
    public MoneyBag? totalDutiesSet { get; set; } = null;

    /// <summary>
    /// The sum of the prices of all line items in the checkout.
    /// </summary>
    [JsonPropertyName("totalLineItemsPriceSet")]
    public MoneyBag? totalLineItemsPriceSet { get; set; } = null;

    /// <summary>
    /// The sum of all items in the checkout, including discounts, shipping, taxes, and tips.
    /// </summary>
    [JsonPropertyName("totalPriceSet")]
    public MoneyBag? totalPriceSet { get; set; } = null;

    /// <summary>
    /// The total tax applied to the checkout.
    /// </summary>
    [JsonPropertyName("totalTaxSet")]
    public MoneyBag? totalTaxSet { get; set; } = null;

    /// <summary>
    /// The date and time when the checkout was most recently updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}