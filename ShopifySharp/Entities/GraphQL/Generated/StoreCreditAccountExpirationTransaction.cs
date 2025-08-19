#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An expiration transaction which decreases the store credit account balance.
/// Expiration transactions are created automatically when a [store credit account credit transaction](https://shopify.dev/api/admin-graphql/latest/objects/StoreCreditAccountCreditTransaction) expires.
/// The amount subtracted from the balance is equal to the remaining amount of the credit transaction.
/// </summary>
public record StoreCreditAccountExpirationTransaction : IGraphQLObject, IStoreCreditAccountTransaction
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
    /// The credit transaction which expired.
    /// </summary>
    [JsonPropertyName("creditTransaction")]
    public StoreCreditAccountCreditTransaction? creditTransaction { get; set; } = null;

    /// <summary>
    /// The event that caused the store credit account transaction.
    /// </summary>
    [JsonPropertyName("event")]
    public StoreCreditSystemEvent? @event { get; set; } = null;

    /// <summary>
    /// The origin of the store credit account transaction.
    /// </summary>
    [JsonPropertyName("origin")]
    public StoreCreditAccountTransactionOrigin? origin { get; set; } = null;
}