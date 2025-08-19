#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `deliveryCustomizationDelete` mutation.
/// </summary>
public record DeliveryCustomizationDeletePayload : IGraphQLObject
{
    /// <summary>
    /// Returns the deleted delivery customization ID.
    /// </summary>
    [JsonPropertyName("deletedId")]
    public string? deletedId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DeliveryCustomizationError>? userErrors { get; set; } = null;
}