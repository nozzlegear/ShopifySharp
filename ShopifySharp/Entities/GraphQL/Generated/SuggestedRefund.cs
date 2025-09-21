#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a refund suggested by Shopify based on the items being reimbursed.
/// You can then use the suggested refund object to generate an actual refund.
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