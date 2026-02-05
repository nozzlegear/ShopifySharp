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
/// Return type for `reverseDeliveryShippingUpdate` mutation.
/// </summary>
public record ReverseDeliveryShippingUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated reverse delivery.
    /// </summary>
    [JsonPropertyName("reverseDelivery")]
    public ReverseDelivery? reverseDelivery { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ReturnUserError>? userErrors { get; set; } = null;
}