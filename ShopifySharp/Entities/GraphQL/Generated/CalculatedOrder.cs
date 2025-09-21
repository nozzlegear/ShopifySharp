#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// An order with edits applied but not saved.
/// </summary>
public record CalculatedOrder : IGraphQLObject, INode
{
    /// <summary>
    /// Returns only the new discount applications being added to the order in the current edit.
    /// </summary>
    [JsonPropertyName("addedDiscountApplications")]
    public CalculatedDiscountApplicationConnection? addedDiscountApplications { get; set; } = null;

    /// <summary>
    /// Returns only the new line items being added to the order during the current edit.
    /// </summary>
    [JsonPropertyName("addedLineItems")]
    public CalculatedLineItemConnection? addedLineItems { get; set; } = null;

    /// <summary>
    /// Amount of the order-level discount (doesn't contain any line item discounts) in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("cartDiscountAmountSet")]
    public MoneyBag? cartDiscountAmountSet { get; set; } = null;

    /// <summary>
    /// Whether the changes have been applied and saved to the order.
    /// </summary>
    [JsonPropertyName("committed")]
    [Obsolete("CalculatedOrder for committed order edits is being deprecated, and this field will also be removed in a future version.  See [changelog](https://shopify.dev/changelog/deprecation-notice-calculatedorder-for-committed-order-edits) for more details.")]
    public bool? committed { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Returns all items on the order that existed before starting the edit.
    /// Will include any changes that have been made.
    /// Will not include line items added during the current edit.
    /// </summary>
    [JsonPropertyName("lineItems")]
    public CalculatedLineItemConnection? lineItems { get; set; } = null;

    /// <summary>
    /// The HTML of the customer notification for the order edit.
    /// </summary>
    [JsonPropertyName("notificationPreviewHtml")]
    public string? notificationPreviewHtml { get; set; } = null;

    /// <summary>
    /// The customer notification title.
    /// </summary>
    [JsonPropertyName("notificationPreviewTitle")]
    public string? notificationPreviewTitle { get; set; } = null;

    /// <summary>
    /// The order without any changes applied.
    /// </summary>
    [JsonPropertyName("originalOrder")]
    public Order? originalOrder { get; set; } = null;

    /// <summary>
    /// Returns the shipping lines on the order that existed before starting the edit.
    /// Will include any changes that have been made as well as shipping lines added during the current edit.
    /// Returns only the first 250 shipping lines.
    /// </summary>
    [JsonPropertyName("shippingLines")]
    public ICollection<CalculatedShippingLine>? shippingLines { get; set; } = null;

    /// <summary>
    /// List of changes made to the order during the current edit.
    /// </summary>
    [JsonPropertyName("stagedChanges")]
    public OrderStagedChangeConnection? stagedChanges { get; set; } = null;

    /// <summary>
    /// The sum of the quantities for the line items that contribute to the order's subtotal.
    /// </summary>
    [JsonPropertyName("subtotalLineItemsQuantity")]
    public int? subtotalLineItemsQuantity { get; set; } = null;

    /// <summary>
    /// The subtotal of the line items, in shop and presentment currencies, after all
    /// the discounts are applied.  The subtotal doesn't include shipping.  The
    /// subtotal includes taxes for taxes-included orders and excludes taxes for
    /// taxes-excluded orders.
    /// </summary>
    [JsonPropertyName("subtotalPriceSet")]
    public MoneyBag? subtotalPriceSet { get; set; } = null;

    /// <summary>
    /// Taxes charged for the line item.
    /// </summary>
    [JsonPropertyName("taxLines")]
    public ICollection<TaxLine>? taxLines { get; set; } = null;

    /// <summary>
    /// Total price of the order less the total amount received from the customer in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("totalOutstandingSet")]
    public MoneyBag? totalOutstandingSet { get; set; } = null;

    /// <summary>
    /// Total amount of the order (includes taxes and discounts) in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("totalPriceSet")]
    public MoneyBag? totalPriceSet { get; set; } = null;
}