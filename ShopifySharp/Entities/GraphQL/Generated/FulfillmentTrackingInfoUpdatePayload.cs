#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `fulfillmentTrackingInfoUpdate` mutation.
/// </summary>
public record FulfillmentTrackingInfoUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated fulfillment with tracking information.
    /// </summary>
    [JsonPropertyName("fulfillment")]
    public Fulfillment? fulfillment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}