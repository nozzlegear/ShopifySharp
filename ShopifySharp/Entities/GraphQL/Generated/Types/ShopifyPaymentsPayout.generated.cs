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
/// A transfer of funds between a merchant's Shopify Payments balance and their [`ShopifyPaymentsBankAccount`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShopifyPaymentsBankAccount).
/// Provides the [net amount](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShopifyPaymentsPayout#field-ShopifyPaymentsPayout.fields.net), [issue date](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShopifyPaymentsPayout#field-ShopifyPaymentsPayout.fields.issuedAt), and current [`ShopifyPaymentsPayoutStatus`](https://shopify.dev/docs/api/admin-graphql/latest/enums/ShopifyPaymentsPayoutStatus).
/// The payout includes a [`ShopifyPaymentsPayoutSummary`](https://shopify.dev/docs/api/admin-graphql/latest/objects/ShopifyPaymentsPayoutSummary)
/// that breaks down fees and gross amounts by transaction type, such as charges,
/// refunds, and adjustments. The [`ShopifyPaymentsPayoutTransactionType`](https://shopify.dev/docs/api/admin-graphql/latest/enums/ShopifyPaymentsPayoutTransactionType)
/// indicates whether funds move into the bank account (deposit) or back to Shopify
/// Payments (withdrawal).
/// </summary>
public record ShopifyPaymentsPayout : IGraphQLObject, ILegacyInteroperability, INode
{
    /// <summary>
    /// The bank account for the payout.
    /// </summary>
    [JsonPropertyName("bankAccount")]
    [Obsolete("Use `destinationAccount` instead.")]
    public ShopifyPaymentsBankAccount? bankAccount { get; set; } = null;

    /// <summary>
    /// The business entity associated with the payout.
    /// </summary>
    [JsonPropertyName("businessEntity")]
    public BusinessEntity? businessEntity { get; set; } = null;

    /// <summary>
    /// A unique trace ID from the financial institution. Use this reference number to track the payout with your provider.
    /// </summary>
    [JsonPropertyName("externalTraceId")]
    public string? externalTraceId { get; set; } = null;

    /// <summary>
    /// The total amount and currency of the payout.
    /// </summary>
    [JsonPropertyName("gross")]
    [Obsolete("Use `net` instead.")]
    public MoneyV2? gross { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The exact time when the payout was issued. The payout only contains
    /// balance transactions that were available at this time.
    /// </summary>
    [JsonPropertyName("issuedAt")]
    public DateTimeOffset? issuedAt { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The total amount and currency of the payout.
    /// </summary>
    [JsonPropertyName("net")]
    public MoneyV2? net { get; set; } = null;

    /// <summary>
    /// The transfer status of the payout.
    /// </summary>
    [JsonPropertyName("status")]
    public ShopifyPaymentsPayoutStatus? status { get; set; } = null;

    /// <summary>
    /// The summary of the payout.
    /// </summary>
    [JsonPropertyName("summary")]
    public ShopifyPaymentsPayoutSummary? summary { get; set; } = null;

    /// <summary>
    /// The direction of the payout.
    /// </summary>
    [JsonPropertyName("transactionType")]
    public ShopifyPaymentsPayoutTransactionType? transactionType { get; set; } = null;
}