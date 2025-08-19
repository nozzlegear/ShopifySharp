#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

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
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? expiresAt { get; set; } = null;
}