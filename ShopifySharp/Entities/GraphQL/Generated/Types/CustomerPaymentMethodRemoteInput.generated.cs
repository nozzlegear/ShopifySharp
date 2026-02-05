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
/// The input fields for a remote gateway payment method, only one remote reference permitted.
/// </summary>
public record CustomerPaymentMethodRemoteInput : GraphQLInputObject<CustomerPaymentMethodRemoteInput>
{
    /// <summary>
    /// The input fields for a remote authorize net customer profile.
    /// </summary>
    [JsonPropertyName("authorizeNetCustomerPaymentProfile")]
    public RemoteAuthorizeNetCustomerPaymentProfileInput? authorizeNetCustomerPaymentProfile { get; set; } = null;

    /// <summary>
    /// The input fields for a remote Braintree customer profile.
    /// </summary>
    [JsonPropertyName("braintreePaymentMethod")]
    public RemoteBraintreePaymentMethodInput? braintreePaymentMethod { get; set; } = null;

    /// <summary>
    /// Input containing the fields for a remote stripe credit card.
    /// </summary>
    [JsonPropertyName("stripePaymentMethod")]
    public RemoteStripePaymentMethodInput? stripePaymentMethod { get; set; } = null;
}