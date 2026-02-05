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
/// Return type for `customerPaymentMethodGetUpdateUrl` mutation.
/// </summary>
public record CustomerPaymentMethodGetUpdateUrlPayload : IGraphQLObject
{
    /// <summary>
    /// The URL to redirect the customer to update the payment method.
    /// </summary>
    [JsonPropertyName("updatePaymentMethodUrl")]
    public string? updatePaymentMethodUrl { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<CustomerPaymentMethodGetUpdateUrlUserError>? userErrors { get; set; } = null;
}