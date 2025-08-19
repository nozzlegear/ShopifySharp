#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `paymentTermsUpdate` mutation.
/// </summary>
public record PaymentTermsUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated payment terms.
    /// </summary>
    [JsonPropertyName("paymentTerms")]
    public PaymentTerms? paymentTerms { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PaymentTermsUpdateUserError>? userErrors { get; set; } = null;
}