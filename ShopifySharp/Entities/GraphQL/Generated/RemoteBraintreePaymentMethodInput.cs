#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a remote Braintree customer payment profile.
/// </summary>
public record RemoteBraintreePaymentMethodInput : GraphQLInputObject<RemoteBraintreePaymentMethodInput>
{
    /// <summary>
    /// The `customer_id` value from the Braintree API.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? customerId { get; set; } = null;

    /// <summary>
    /// The `payment_method_token` value from the Braintree API. Starting on 2025,
    /// payment_method_token will become mandatory for all API versions.
    /// </summary>
    [JsonPropertyName("paymentMethodToken")]
    public string? paymentMethodToken { get; set; } = null;
}