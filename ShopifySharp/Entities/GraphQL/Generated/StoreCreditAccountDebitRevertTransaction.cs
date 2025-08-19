#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A debit revert transaction which increases the store credit account balance.
/// Debit revert transactions are created automatically when a [store credit account debit transaction](https://shopify.dev/api/admin-graphql/latest/objects/StoreCreditAccountDebitTransaction) is reverted.
/// Store credit account debit transactions are reverted when an order is cancelled,
/// refunded or in the event of a payment failure at checkout.
/// The amount added to the balance is equal to the amount reverted on the original credit.
/// </summary>
public record StoreCreditAccountDebitRevertTransaction : IGraphQLObject, INode, IStoreCreditAccountTransaction
{
    /// <summary>
    /// The store credit account that the transaction belongs to.
    /// </summary>
    [JsonPropertyName("account")]
    public StoreCreditAccount? account { get; set; } = null;

    /// <summary>
    /// The amount of the transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; } = null;

    /// <summary>
    /// The balance of the account after the transaction.
    /// </summary>
    [JsonPropertyName("balanceAfterTransaction")]
    public MoneyV2? balanceAfterTransaction { get; set; } = null;

    /// <summary>
    /// The date and time when the transaction was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The reverted debit transaction.
    /// </summary>
    [JsonPropertyName("debitTransaction")]
    public StoreCreditAccountDebitTransaction? debitTransaction { get; set; } = null;

    /// <summary>
    /// The event that caused the store credit account transaction.
    /// </summary>
    [JsonPropertyName("event")]
    public StoreCreditSystemEvent? @event { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The origin of the store credit account transaction.
    /// </summary>
    [JsonPropertyName("origin")]
    public StoreCreditAccountTransactionOrigin? origin { get; set; } = null;
}