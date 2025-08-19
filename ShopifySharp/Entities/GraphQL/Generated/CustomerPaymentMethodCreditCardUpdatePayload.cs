#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `customerPaymentMethodCreditCardUpdate` mutation.
/// </summary>
public record CustomerPaymentMethodCreditCardUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The customer payment method.
    /// </summary>
    [JsonPropertyName("customerPaymentMethod")]
    public CustomerPaymentMethod? customerPaymentMethod { get; set; } = null;

    /// <summary>
    /// If the card verification result is processing. When this is true, customer_payment_method will be null.
    /// </summary>
    [JsonPropertyName("processing")]
    public bool? processing { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}