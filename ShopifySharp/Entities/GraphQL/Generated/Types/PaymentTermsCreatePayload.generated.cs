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