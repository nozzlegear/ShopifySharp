#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a credit card payment instrument.
/// </summary>
public record VaultCreditCard : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The billing address of the card.
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public CustomerCreditCardBillingAddress? billingAddress { get; set; } = null;

    /// <summary>
    /// The brand for the card.
    /// </summary>
    [JsonPropertyName("brand")]
    public string? brand { get; set; } = null;

    /// <summary>
    /// Whether the card has been expired.
    /// </summary>
    [JsonPropertyName("expired")]
    public bool? expired { get; set; } = null;

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
    /// The last four digits for the card.
    /// </summary>
    [JsonPropertyName("lastDigits")]
    public string? lastDigits { get; set; } = null;

    /// <summary>
    /// The name of the card holder.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}