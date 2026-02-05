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
/// Return type for `customerPaymentMethodGetDuplicationData` mutation.
/// </summary>
public record CustomerPaymentMethodGetDuplicationDataPayload : IGraphQLObject
{
    /// <summary>
    /// The encrypted data from the payment method to be duplicated.
    /// </summary>
    [JsonPropertyName("encryptedDuplicationData")]
    public string? encryptedDuplicationData { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CustomerPaymentMethodGetDuplicationDataUserError>? userErrors { get; set; } = null;
}