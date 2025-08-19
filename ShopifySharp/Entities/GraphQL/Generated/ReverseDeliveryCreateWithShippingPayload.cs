#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `reverseDeliveryCreateWithShipping` mutation.
/// </summary>
public record ReverseDeliveryCreateWithShippingPayload : IGraphQLObject
{
    /// <summary>
    /// The created reverse delivery.
    /// </summary>
    [JsonPropertyName("reverseDelivery")]
    public ReverseDelivery? reverseDelivery { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ReturnUserError>? userErrors { get; set; } = null;
}