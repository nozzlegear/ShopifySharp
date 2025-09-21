#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A store credit account contains a monetary balance that can be redeemed at checkout for purchases in the shop.
/// The account is held in the specified currency and has an owner that cannot be transferred.
/// The account balance is redeemable at checkout only when the owner is
/// authenticated via [new customer accounts
/// authentication](https://shopify.dev/docs/api/customer).
/// </summary>
public record StoreCreditAccount : IGraphQLObject, INode
{
    /// <summary>
    /// The current balance of the store credit account.
    /// </summary>
    [JsonPropertyName("balance")]
    public MoneyV2? balance { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The owner of the store credit account.
    /// </summary>
    [JsonPropertyName("owner")]
    public IHasStoreCreditAccounts? owner { get; set; } = null;

    /// <summary>
    /// The transaction history of the store credit account.
    /// </summary>
    [JsonPropertyName("transactions")]
    public StoreCreditAccountTransactionConnection? transactions { get; set; } = null;
}