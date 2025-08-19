#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `paymentTermsDelete` mutation.
/// </summary>
public record PaymentTermsDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The deleted payment terms ID.
    /// </summary>
    [JsonPropertyName("deletedId")]
    public string? deletedId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PaymentTermsDeleteUserError>? userErrors { get; set; } = null;
}