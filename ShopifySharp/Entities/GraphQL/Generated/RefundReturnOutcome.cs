#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The financial transfer details for a return outcome that results in a refund.
/// </summary>
public record RefundReturnOutcome : ReturnOutcomeFinancialTransfer, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The total monetary value to be refunded in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyBag? amount { get; set; } = null;

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
}