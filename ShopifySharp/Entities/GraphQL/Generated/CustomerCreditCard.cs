#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a card instrument for customer payment method.
/// </summary>
public record CustomerCreditCard : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The billing address of the card.
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public CustomerCreditCardBillingAddress? billingAddress { get; set; } = null;

    /// <summary>
    /// The brand of the card.
    /// </summary>
    [JsonPropertyName("brand")]
    public string? brand { get; set; } = null;

    /// <summary>
    /// Whether the card is about to expire.
    /// </summary>
    [JsonPropertyName("expiresSoon")]
    public bool? expiresSoon { get; set; } = null;

    /// <summary>
    /// The expiry month of the card.
    /// </summary>
    [JsonPropertyName("expiryMonth")]
    public int? expiryMonth { get; set; } = null;

    /// <summary>
    /// The expiry year of the card.
    /// </summary>
    [JsonPropertyName("expiryYear")]
    public int? expiryYear { get; set; } = null;

    /// <summary>
    /// The card's BIN number.
    /// </summary>
    [JsonPropertyName("firstDigits")]
    public string? firstDigits { get; set; } = null;

    /// <summary>
    /// The payment method can be revoked if there are no active subscription contracts.
    /// </summary>
    [JsonPropertyName("isRevocable")]
    public bool? isRevocable { get; set; } = null;

    /// <summary>
    /// The last 4 digits of the card.
    /// </summary>
    [JsonPropertyName("lastDigits")]
    public string? lastDigits { get; set; } = null;

    /// <summary>
    /// The masked card number with only the last 4 digits displayed.
    /// </summary>
    [JsonPropertyName("maskedNumber")]
    public string? maskedNumber { get; set; } = null;

    /// <summary>
    /// The name of the card holder.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The source of the card if coming from a wallet such as Apple Pay.
    /// </summary>
    [JsonPropertyName("source")]
    public string? source { get; set; } = null;

    /// <summary>
    /// The last 4 digits of the Device Account Number.
    /// </summary>
    [JsonPropertyName("virtualLastDigits")]
    public string? virtualLastDigits { get; set; } = null;
}