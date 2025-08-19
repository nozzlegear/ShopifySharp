#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `customerPaymentMethodRemoteCreate` mutation.
/// </summary>
public record CustomerPaymentMethodRemoteCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The customer payment method. Note that the returned payment method may
    /// initially be in an incomplete state. Developers should poll this payment
    /// method using the customerPaymentMethod query until all required payment
    /// details have been processed.
    /// </summary>
    [JsonPropertyName("customerPaymentMethod")]
    public CustomerPaymentMethod? customerPaymentMethod { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CustomerPaymentMethodRemoteUserError>? userErrors { get; set; } = null;
}