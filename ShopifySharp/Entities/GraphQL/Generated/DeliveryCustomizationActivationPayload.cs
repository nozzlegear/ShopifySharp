#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `deliveryCustomizationActivation` mutation.
/// </summary>
public record DeliveryCustomizationActivationPayload : IGraphQLObject
{
    /// <summary>
    /// The IDs of the updated delivery customizations.
    /// </summary>
    [JsonPropertyName("ids")]
    public ICollection<string>? ids { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<DeliveryCustomizationError>? userErrors { get; set; } = null;
}