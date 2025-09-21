#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a transaction to create for an order.
/// </summary>
public record OrderCreateOrderTransactionInput : GraphQLInputObject<OrderCreateOrderTransactionInput>
{
    /// <summary>
    /// The amount of the transaction.
    /// </summary>
    [JsonPropertyName("amountSet")]
    public MoneyBagInput? amountSet { get; set; } = null;

    /// <summary>
    /// The authorization code associated with the transaction.
    /// </summary>
    [JsonPropertyName("authorizationCode")]
    public string? authorizationCode { get; set; } = null;

    /// <summary>
    /// The ID of the device used to process the transaction.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public string? deviceId { get; set; } = null;

    /// <summary>
    /// The name of the gateway the transaction was issued through.
    /// </summary>
    [JsonPropertyName("gateway")]
    public string? gateway { get; set; } = null;

    /// <summary>
    /// The ID of the gift card used for this transaction.
    /// </summary>
    [JsonPropertyName("giftCardId")]
    public string? giftCardId { get; set; } = null;

    /// <summary>
    /// The kind of transaction.
    /// </summary>
    [JsonPropertyName("kind")]
    public OrderTransactionKind? kind { get; set; } = null;

    /// <summary>
    /// The ID of the location where the transaction was processed.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;

    /// <summary>
    /// The date and time when the transaction was processed.
    /// </summary>
    [JsonPropertyName("processedAt")]
    public DateTime? processedAt { get; set; } = null;

    /// <summary>
    /// The transaction receipt that the payment gateway attaches to the transaction.
    /// The value of this field depends on which payment gateway processed the transaction.
    /// </summary>
    [JsonPropertyName("receiptJson")]
    public string? receiptJson { get; set; } = null;

    /// <summary>
    /// The status of the transaction.
    /// </summary>
    [JsonPropertyName("status")]
    public OrderTransactionStatus? status { get; set; } = null;

    /// <summary>
    /// Whether the transaction is a test transaction.
    /// </summary>
    [JsonPropertyName("test")]
    public bool? test { get; set; } = null;

    /// <summary>
    /// The ID of the user who processed the transaction.
    /// </summary>
    [JsonPropertyName("userId")]
    public string? userId { get; set; } = null;
}