#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `customerPaymentMethodRevoke` mutation.
/// </summary>
public record CustomerPaymentMethodRevokePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the revoked customer payment method.
    /// </summary>
    [JsonPropertyName("revokedCustomerPaymentMethodId")]
    public string? revokedCustomerPaymentMethodId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}