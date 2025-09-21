#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `paymentCustomizationDelete` mutation.
/// </summary>
public record PaymentCustomizationDeletePayload : IGraphQLObject
{
    /// <summary>
    /// Returns the deleted payment customization ID.
    /// </summary>
    [JsonPropertyName("deletedId")]
    public string? deletedId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<PaymentCustomizationError>? userErrors { get; set; } = null;
}