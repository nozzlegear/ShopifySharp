#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A bank account that can receive payouts.
/// </summary>
public record ShopifyPaymentsBankAccount : IGraphQLObject, INode
{
    /// <summary>
    /// The last digits of the account number (the rest is redacted).
    /// </summary>
    [JsonPropertyName("accountNumberLastDigits")]
    public string? accountNumberLastDigits { get; set; } = null;

    /// <summary>
    /// The name of the bank.
    /// </summary>
    [JsonPropertyName("bankName")]
    public string? bankName { get; set; } = null;

    /// <summary>
    /// The country of the bank.
    /// </summary>
    [JsonPropertyName("country")]
    public CountryCode? country { get; set; } = null;

    /// <summary>
    /// The date that the bank account was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; } = null;

    /// <summary>
    /// The currency of the bank account.
    /// </summary>
    [JsonPropertyName("currency")]
    public CurrencyCode? currency { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// All current and previous payouts made between the account and the bank account.
    /// </summary>
    [JsonPropertyName("payouts")]
    public ShopifyPaymentsPayoutConnection? payouts { get; set; } = null;

    /// <summary>
    /// The status of the bank account.
    /// </summary>
    [JsonPropertyName("status")]
    public ShopifyPaymentsBankAccountStatus? status { get; set; } = null;
}