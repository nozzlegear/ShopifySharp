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
/// Interface for a store credit account transaction.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(StoreCreditAccountCreditTransaction), typeDiscriminator: "StoreCreditAccountCreditTransaction")]
[JsonDerivedType(typeof(StoreCreditAccountDebitRevertTransaction), typeDiscriminator: "StoreCreditAccountDebitRevertTransaction")]
[JsonDerivedType(typeof(StoreCreditAccountDebitTransaction), typeDiscriminator: "StoreCreditAccountDebitTransaction")]
[JsonDerivedType(typeof(StoreCreditAccountExpirationTransaction), typeDiscriminator: "StoreCreditAccountExpirationTransaction")]
public interface IStoreCreditAccountTransaction : IGraphQLObject
{
    /// <summary>
    /// The store credit account that the transaction belongs to.
    /// </summary>
    [JsonPropertyName("account")]
    public StoreCreditAccount? account { get; set; }

    /// <summary>
    /// The amount of the transaction.
    /// </summary>
    [JsonPropertyName("amount")]
    public MoneyV2? amount { get; set; }

    /// <summary>
    /// The balance of the account after the transaction.
    /// </summary>
    [JsonPropertyName("balanceAfterTransaction")]
    public MoneyV2? balanceAfterTransaction { get; set; }

    /// <summary>
    /// The date and time when the transaction was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTimeOffset? createdAt { get; set; }

    /// <summary>
    /// The event that caused the store credit account transaction.
    /// </summary>
    [JsonPropertyName("event")]
    public StoreCreditSystemEvent? @event { get; set; }

    /// <summary>
    /// The origin of the store credit account transaction.
    /// </summary>
    [JsonPropertyName("origin")]
    public StoreCreditAccountTransactionOrigin? origin { get; set; }
}