#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `paymentTermsCreate` mutation.
/// </summary>
public record PaymentTermsCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created payment terms.
    /// </summary>
    [JsonPropertyName("paymentTerms")]
    public PaymentTerms? paymentTerms { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PaymentTermsCreateUserError>? userErrors { get; set; } = null;
}