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
/// The input fields for a store credit account credit transaction.
/// </summary>
public record StoreCreditAccountCreditInput : GraphQLInputObject<StoreCreditAccountCreditInput>
{
    /// <summary>
    /// The amount to credit the store credit account.
    /// </summary>
    [JsonPropertyName("creditAmount")]
    public MoneyInput? creditAmount { get; set; } = null;

    /// <summary>
    /// The date and time when the credit expires.
    /// </summary>
    [JsonPropertyName("expiresAt")]
    public DateTimeOffset? expiresAt { get; set; } = null;

    /// <summary>
    /// Whether to send a notification to the account owner when the store credit is issued.
    /// Defaults to `false`.
    /// </summary>
    [JsonPropertyName("notify")]
    public bool? notify { get; set; } = null;
}