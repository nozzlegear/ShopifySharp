#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Card payment details related to a transaction.
/// </summary>
public record CardPaymentDetails : IGraphQLUnionCase, IGraphQLObject, IBasePaymentDetails
{
    /// <summary>
    /// The response code from the address verification system (AVS). The code is always a single letter.
    /// </summary>
    [JsonPropertyName("avsResultCode")]
    public string? avsResultCode { get; set; } = null;

    /// <summary>
    /// The issuer identification number (IIN), formerly known as bank identification
    /// number (BIN) of the customer's credit card. This is made up of the first few
    /// digits of the credit card number.
    /// </summary>
    [JsonPropertyName("bin")]
    public string? bin { get; set; } = null;

    /// <summary>
    /// The name of the company that issued the customer's credit card.
    /// </summary>
    [JsonPropertyName("company")]
    public string? company { get; set; } = null;

    /// <summary>
    /// The response code from the credit card company indicating whether the customer
    /// entered the card security code, or card verification value, correctly. The
    /// code is a single letter or empty string.
    /// </summary>
    [JsonPropertyName("cvvResultCode")]
    public string? cvvResultCode { get; set; } = null;

    /// <summary>
    /// The month in which the used credit card expires.
    /// </summary>
    [JsonPropertyName("expirationMonth")]
    public int? expirationMonth { get; set; } = null;

    /// <summary>
    /// The year in which the used credit card expires.
    /// </summary>
    [JsonPropertyName("expirationYear")]
    public int? expirationYear { get; set; } = null;

    /// <summary>
    /// The holder of the credit card.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The customer's credit card number, with most of the leading digits redacted.
    /// </summary>
    [JsonPropertyName("number")]
    public string? number { get; set; } = null;

    /// <summary>
    /// The name of payment method used by the buyer.
    /// </summary>
    [JsonPropertyName("paymentMethodName")]
    public string? paymentMethodName { get; set; } = null;

    /// <summary>
    /// Digital wallet used for the payment.
    /// </summary>
    [JsonPropertyName("wallet")]
    public DigitalWallet? wallet { get; set; } = null;
}