#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a PayPal instrument for customer payment method.
/// </summary>
public record CustomerPaypalBillingAgreement : CustomerPaymentInstrument, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The billing address of this payment method.
    /// </summary>
    [JsonPropertyName("billingAddress")]
    public CustomerPaymentInstrumentBillingAddress? billingAddress { get; set; } = null;

    /// <summary>
    /// Whether the PayPal billing agreement is inactive.
    /// </summary>
    [JsonPropertyName("inactive")]
    public bool? inactive { get; set; } = null;

    /// <summary>
    /// Whether the payment method can be revoked.The payment method can be revoked if there are no active subscription contracts.
    /// </summary>
    [JsonPropertyName("isRevocable")]
    public bool? isRevocable { get; set; } = null;

    /// <summary>
    /// The customers's PayPal account email address.
    /// </summary>
    [JsonPropertyName("paypalAccountEmail")]
    public string? paypalAccountEmail { get; set; } = null;
}