#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `fulfillmentOrderAcceptFulfillmentRequest` mutation.
/// </summary>
public record FulfillmentOrderAcceptFulfillmentRequestPayload : IGraphQLObject
{
    /// <summary>
    /// The fulfillment order whose fulfillment request was accepted.
    /// </summary>
    [JsonPropertyName("fulfillmentOrder")]
    public FulfillmentOrder? fulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}