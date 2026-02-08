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
/// Represents a Shop Pay card instrument for customer payment method.
/// </summary>
public record CustomerShopPayAgreement : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The billing address of the card.
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public CustomerCreditCardBillingAddress? billingAddress { get; set; } = null;

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
    /// Whether the Shop Pay billing agreement is inactive.
    /// </summary>
    [JsonPropertyName("inactive")]
    public bool? inactive { get; set; } = null;

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
}