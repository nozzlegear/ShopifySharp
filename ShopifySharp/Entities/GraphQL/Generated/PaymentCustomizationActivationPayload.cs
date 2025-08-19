#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `paymentCustomizationActivation` mutation.
/// </summary>
public record PaymentCustomizationActivationPayload : IGraphQLObject
{
    /// <summary>
    /// The IDs of the updated payment customizations.
    /// </summary>
    [JsonPropertyName("ids")]
    public ICollection<string>? ids { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PaymentCustomizationError>? userErrors { get; set; } = null;
}