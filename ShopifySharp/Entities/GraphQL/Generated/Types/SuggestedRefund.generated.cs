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
/// A refund amount that Shopify suggests based on the items, duties, and shipping
/// costs that customers return. Provides a breakdown of all monetary values
/// including subtotals, taxes, discounts, and the maximum refundable amount.
/// The suggested refund includes [`RefundLineItem`](https://shopify.dev/docs/api/admin-graphql/latest/objects/RefundLineItem)
/// objects to refund with their quantities and restock instructions, [`RefundDuty`](https://shopify.dev/docs/api/admin-graphql/latest/objects/RefundDuty)
/// objects for duty reimbursements, and [`ShippingRefund`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShippingRefund)
/// for shipping cost refunds. Provides [`SuggestedOrderTransaction`](https://shopify.dev/docs/api/admin-graphql/latest/objects/SuggestedOrderTransaction)
/// objects and the [`SuggestedRefundMethod`](https://shopify.dev/docs/api/admin-graphql/latest/interfaces/SuggestedRefundMethod)
/// interface to process the refund through the appropriate gateways.
/// Learn more about [previewing and refunding duties](https://shopify.dev/docs/apps/build/orders-fulfillment/returns-apps/view-and-refund-duties#step-3-preview-a-refund-that-includes-duties).
/// </summary>
public record SuggestedRefund : IGraphQLObject
{
    /// <summary>
    /// The total monetary value to be refunded.
    /// </summary>
    [JsonPropertyName("amount")]
    [Obsolete("Use `amountSet` instead.")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// The total monetary value to be refunded in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amountSet")]
    public MoneyBag? amountSet { get; set; } = null;

    /// <summary>
    /// The sum of all the discounted prices of the line items being refunded.
    /// </summary>
    [JsonPropertyName("discountedSubtotalSet")]
    public MoneyBag? discountedSubtotalSet { get; set; } = null;

    /// <summary>
    /// The total monetary value available to refund.
    /// </summary>
    [JsonPropertyName("maximumRefundable")]
    [Obsolete("Use `maximumRefundableSet` instead.")]
    public decimal? maximumRefundable { get; set; } = null;

    /// <summary>
    /// The total monetary value available to refund in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("maximumRefundableSet")]
    public MoneyBag? maximumRefundableSet { get; set; } = null;

    /// <summary>
    /// A list of duties to be refunded from the order.
    /// </summary>
    [JsonPropertyName("refundDuties")]
    public ICollection<RefundDuty>? refundDuties { get; set; } = null;

    /// <summary>
    /// A list of line items to be refunded, along with restock instructions.
    /// </summary>
    [JsonPropertyName("refundLineItems")]
    public ICollection<RefundLineItem>? refundLineItems { get; set; } = null;

    /// <summary>
    /// The shipping costs to be refunded from the order.
    /// </summary>
    [JsonPropertyName("shipping")]
    public ShippingRefund? shipping { get; set; } = null;

    /// <summary>
    /// The sum of all the prices of the line items being refunded.
    /// </summary>
    [JsonPropertyName("subtotal")]
    [Obsolete("Use `subtotalSet` instead.")]
    public decimal? subtotal { get; set; } = null;

    /// <summary>
    /// The sum of all the prices of the line items being refunded in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("subtotalSet")]
    public MoneyBag? subtotalSet { get; set; } = null;

    /// <summary>
    /// A list of suggested refund methods.
    /// </summary>
    [JsonPropertyName("suggestedRefundMethods")]
    public ICollection<ISuggestedRefundMethod>? suggestedRefundMethods { get; set; } = null;

    /// <summary>
    /// A list of suggested order transactions.
    /// </summary>
    [JsonPropertyName("suggestedTransactions")]
    public ICollection<SuggestedOrderTransaction>? suggestedTransactions { get; set; } = null;

    /// <summary>
    /// The total cart discount amount that was applied to all line items in this refund.
    /// </summary>
    [JsonPropertyName("totalCartDiscountAmountSet")]
    public MoneyBag? totalCartDiscountAmountSet { get; set; } = null;

    /// <summary>
    /// The sum of all the duties being refunded from the order in shop and presentment currencies. The value must be positive.
    /// </summary>
    [JsonPropertyName("totalDutiesSet")]
    public MoneyBag? totalDutiesSet { get; set; } = null;

    /// <summary>
    /// The sum of the taxes being refunded from the order. The value must be positive.
    /// </summary>
    [JsonPropertyName("totalTaxes")]
    [Obsolete("Use `totalTaxSet` instead.")]
    public decimal? totalTaxes { get; set; } = null;

    /// <summary>
    /// The sum of the taxes being refunded from the order in shop and presentment currencies. The value must be positive.
    /// </summary>
    [JsonPropertyName("totalTaxSet")]
    public MoneyBag? totalTaxSet { get; set; } = null;
}