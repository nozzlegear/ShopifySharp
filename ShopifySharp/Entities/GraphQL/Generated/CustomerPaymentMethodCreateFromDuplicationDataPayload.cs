#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `customerPaymentMethodCreateFromDuplicationData` mutation.
/// </summary>
public record CustomerPaymentMethodCreateFromDuplicationDataPayload : IGraphQLObject
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
    public ICollection<CustomerPaymentMethodCreateFromDuplicationDataUserError>? userErrors { get; set; } = null;
}