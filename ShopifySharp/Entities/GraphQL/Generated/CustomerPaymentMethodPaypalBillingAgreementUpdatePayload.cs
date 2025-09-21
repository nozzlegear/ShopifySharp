#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `customerPaymentMethodPaypalBillingAgreementUpdate` mutation.
/// </summary>
public record CustomerPaymentMethodPaypalBillingAgreementUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The customer payment method.
    /// </summary>
    [JsonPropertyName("customerPaymentMethod")]
    public CustomerPaymentMethod? customerPaymentMethod { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CustomerPaymentMethodUserError>? userErrors { get; set; } = null;
}