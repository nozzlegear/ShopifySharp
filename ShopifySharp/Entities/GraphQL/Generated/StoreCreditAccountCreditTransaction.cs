#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A credit transaction which increases the store credit account balance.
/// </summary>
public record StoreCreditAccountCreditTransaction : IGraphQLObject, INode, IStoreCreditAccountTransaction
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
    /// The event that caused the store credit account transaction.
    /// </summary>
    [JsonPropertyName("event")]
    public StoreCreditSystemEvent? @event { get; set; } = null;

    /// <summary>
    /// The time at which the transaction expires.
    /// Debit transactions will always spend the soonest expiring credit first.
    /// </summary>
    [JsonPropertyName("expiresAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? expiresAt { get; set; } = null;

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

    /// <summary>
    /// The remaining amount of the credit.
    /// The remaining amount will decrease when a debit spends this credit. It may
    /// also increase if that debit is subsequently reverted.
    /// In the event that the credit expires, the remaining amount will represent the amount that remained as the expiry ocurred.
    /// </summary>
    [JsonPropertyName("remainingAmount")]
    public MoneyV2? remainingAmount { get; set; } = null;
}