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
/// Represents a return financial outcome suggested by Shopify based on the items
/// being reimbursed. You can then use the suggested outcome object to generate an
/// actual refund or invoice for the return.
/// </summary>
public record SuggestedReturnFinancialOutcome : IGraphQLObject
{
    /// <summary>
    /// The sum of all the discounted prices of the line items being refunded.
    /// </summary>
    [JsonPropertyName("discountedSubtotal")]
    public MoneyBag? discountedSubtotal { get; set; } = null;

    /// <summary>
    /// The financial transfer details for the return outcome.
    /// </summary>
    [JsonPropertyName("financialTransfer")]
    public ReturnOutcomeFinancialTransfer? financialTransfer { get; set; } = null;

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
    /// The sum of all the additional fees being refunded in shop and presentment currencies. The value must be positive.
    /// </summary>
    [JsonPropertyName("totalAdditionalFees")]
    public MoneyBag? totalAdditionalFees { get; set; } = null;

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