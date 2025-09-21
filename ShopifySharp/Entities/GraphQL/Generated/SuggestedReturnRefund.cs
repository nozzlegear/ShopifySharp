#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents a return refund suggested by Shopify based on the items being
/// reimbursed. You can then use the suggested refund object to generate an actual
/// refund for the return.
/// </summary>
public record SuggestedReturnRefund : IGraphQLObject
{
    /// <summary>
    /// The total monetary value to be refunded in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyBag? amount { get; set; } = null;

    /// <summary>
    /// The sum of all the discounted prices of the line items being refunded.
    /// </summary>
    [JsonPropertyName("discountedSubtotal")]
    public MoneyBag? discountedSubtotal { get; set; } = null;

    /// <summary>
    /// The total monetary value available to refund in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("maximumRefundable")]
    public MoneyBag? maximumRefundable { get; set; } = null;

    /// <summary>
    /// A list of duties to be refunded from the order.
    /// </summary>
    [JsonPropertyName("refundDuties")]
    public ICollection<RefundDuty>? refundDuties { get; set; } = null;

    /// <summary>
    /// The shipping costs to be refunded from the order.
    /// </summary>
    [JsonPropertyName("shipping")]
    public ShippingRefund? shipping { get; set; } = null;

    /// <summary>
    /// The sum of all the prices of the line items being refunded in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("subtotal")]
    public MoneyBag? subtotal { get; set; } = null;

    /// <summary>
    /// A list of suggested order transactions.
    /// </summary>
    [JsonPropertyName("suggestedTransactions")]
    public ICollection<SuggestedOrderTransaction>? suggestedTransactions { get; set; } = null;

    /// <summary>
    /// The total cart discount amount that was applied to all line items in this refund.
    /// </summary>
    [JsonPropertyName("totalCartDiscountAmount")]
    public MoneyBag? totalCartDiscountAmount { get; set; } = null;

    /// <summary>
    /// The sum of all the duties being refunded from the order in shop and presentment currencies. The value must be positive.
    /// </summary>
    [JsonPropertyName("totalDuties")]
    public MoneyBag? totalDuties { get; set; } = null;

    /// <summary>
    /// The sum of the taxes being refunded in shop and presentment currencies. The value must be positive.
    /// </summary>
    [JsonPropertyName("totalTax")]
    public MoneyBag? totalTax { get; set; } = null;
}