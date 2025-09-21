#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A suggested transaction. Suggested transaction are usually used in the context of refunds
/// and exchanges.
/// </summary>
public record SuggestedOrderTransaction : IGraphQLObject
{
    /// <summary>
    /// The masked account number associated with the payment method.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    public string? accountNumber { get; set; } = null;

    /// <summary>
    /// The amount of the transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    [Obsolete("Use `amountSet` instead.")]
    public decimal? amount { get; set; } = null;

    /// <summary>
    /// The amount and currency of the suggested order transaction in shop and presentment currencies.
    /// </summary>
    [JsonPropertyName("amountSet")]
    public MoneyBag? amountSet { get; set; } = null;

    /// <summary>
    /// The human-readable payment gateway name suggested to process the transaction.
    /// </summary>
    [JsonPropertyName("formattedGateway")]
    public string? formattedGateway { get; set; } = null;

    /// <summary>
    /// The suggested payment gateway used to process the transaction.
    /// </summary>
    [JsonPropertyName("gateway")]
    public string? gateway { get; set; } = null;

    /// <summary>
    /// Specifies the kind of the suggested order transaction.
    /// </summary>
    [JsonPropertyName("kind")]
    public SuggestedOrderTransactionKind? kind { get; set; } = null;

    /// <summary>
    /// Specifies the available amount to refund on the gateway. Only available within SuggestedRefund.
    /// </summary>
    [JsonPropertyName("maximumRefundable")]
    [Obsolete("Use `maximumRefundableSet` instead.")]
    public decimal? maximumRefundable { get; set; } = null;

    /// <summary>
    /// Specifies the available amount to refund on the gateway in shop and
    /// presentment currencies. Only available within SuggestedRefund.
    /// </summary>
    [JsonPropertyName("maximumRefundableSet")]
    public MoneyBag? maximumRefundableSet { get; set; } = null;

    /// <summary>
    /// The associated parent transaction, for example the authorization of a capture.
    /// </summary>
    [JsonPropertyName("parentTransaction")]
    public OrderTransaction? parentTransaction { get; set; } = null;

    /// <summary>
    /// The associated payment details related to the transaction.
    /// </summary>
    [JsonPropertyName("paymentDetails")]
    public PaymentDetails? paymentDetails { get; set; } = null;
}