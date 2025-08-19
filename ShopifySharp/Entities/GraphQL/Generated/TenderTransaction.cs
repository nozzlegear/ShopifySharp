#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A TenderTransaction represents a transaction with financial impact on a shop's balance sheet. A tender transaction always
/// represents actual money movement between a buyer and a shop. TenderTransactions can be used instead of OrderTransactions
/// for reconciling a shop's cash flow. A TenderTransaction is immutable once created.
/// </summary>
public record TenderTransaction : IGraphQLObject, INode
{
    /// <summary>
    /// The amount and currency of the tender transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The order that's related to the tender transaction. This value is null if the order has been deleted.
    /// </summary>
    [JsonPropertyName("order")]
    public Order? order { get; set; } = null;

    /// <summary>
    /// Information about the payment method used for the transaction.
    /// </summary>
    [JsonPropertyName("paymentMethod")]
    public string? paymentMethod { get; set; } = null;

    /// <summary>
    /// Date and time when the transaction was processed.
    /// </summary>
    [JsonPropertyName("processedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? processedAt { get; set; } = null;

    /// <summary>
    /// The remote gateway reference associated with the tender transaction.
    /// </summary>
    [JsonPropertyName("remoteReference")]
    public string? remoteReference { get; set; } = null;

    /// <summary>
    /// Whether the transaction is a test transaction.
    /// </summary>
    [JsonPropertyName("test")]
    public bool? test { get; set; } = null;

    /// <summary>
    /// Information about the payment instrument used for the transaction.
    /// </summary>
    [JsonPropertyName("transactionDetails")]
    public TenderTransactionDetails? transactionDetails { get; set; } = null;

    /// <summary>
    /// The staff member who performed the transaction.
    /// </summary>
    [JsonPropertyName("user")]
    public StaffMember? user { get; set; } = null;
}