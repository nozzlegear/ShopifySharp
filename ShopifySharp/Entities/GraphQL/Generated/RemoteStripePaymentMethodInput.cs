#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a remote stripe payment method.
/// </summary>
public record RemoteStripePaymentMethodInput : GraphQLInputObject<RemoteStripePaymentMethodInput>
{
    /// <summary>
    /// The customer_id value from the Stripe API.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? customerId { get; set; } = null;

    /// <summary>
    /// The payment_method_id value from the Stripe API. Starting on 2025,
    /// payment_method_id will become mandatory for all API versions.
    /// </summary>
    [JsonPropertyName("paymentMethodId")]
    public string? paymentMethodId { get; set; } = null;
}