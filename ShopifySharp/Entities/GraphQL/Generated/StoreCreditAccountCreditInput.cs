#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
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
    public DateTime? expiresAt { get; set; } = null;
}