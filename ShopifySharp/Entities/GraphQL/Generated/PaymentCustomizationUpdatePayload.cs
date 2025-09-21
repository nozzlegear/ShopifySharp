#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `paymentCustomizationUpdate` mutation.
/// </summary>
public record PaymentCustomizationUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// Returns the updated payment customization.
    /// </summary>
    [JsonPropertyName("paymentCustomization")]
    public PaymentCustomization? paymentCustomization { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PaymentCustomizationError>? userErrors { get; set; } = null;
}