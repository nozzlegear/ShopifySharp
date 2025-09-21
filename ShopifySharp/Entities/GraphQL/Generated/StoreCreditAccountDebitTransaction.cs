#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A debit transaction which decreases the store credit account balance.
/// </summary>
public record StoreCreditAccountDebitTransaction : IGraphQLObject, INode, IStoreCreditAccountTransaction
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
    public DateTime? createdAt { get; set; } = null;

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