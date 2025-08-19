#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `fulfillmentOrderReleaseHold` mutation.
/// </summary>
public record FulfillmentOrderReleaseHoldPayload : IGraphQLObject
{
    /// <summary>
    /// The fulfillment order on which the hold was released.
    /// </summary>
    [JsonPropertyName("fulfillmentOrder")]
    public FulfillmentOrder? fulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<FulfillmentOrderReleaseHoldUserError>? userErrors { get; set; } = null;
}