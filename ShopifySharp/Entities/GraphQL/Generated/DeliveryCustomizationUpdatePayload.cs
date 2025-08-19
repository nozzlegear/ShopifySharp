#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `deliveryCustomizationUpdate` mutation.
/// </summary>
public record DeliveryCustomizationUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// Returns the updated delivery customization.
    /// </summary>
    [JsonPropertyName("deliveryCustomization")]
    public DeliveryCustomization? deliveryCustomization { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DeliveryCustomizationError>? userErrors { get; set; } = null;
}