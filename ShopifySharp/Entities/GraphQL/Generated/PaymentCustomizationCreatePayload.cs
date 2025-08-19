#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `paymentCustomizationCreate` mutation.
/// </summary>
public record PaymentCustomizationCreatePayload : IGraphQLObject
{
    /// <summary>
    /// Returns the created payment customization.
    /// </summary>
    [JsonPropertyName("paymentCustomization")]
    public PaymentCustomization? paymentCustomization { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PaymentCustomizationError>? userErrors { get; set; } = null;
}