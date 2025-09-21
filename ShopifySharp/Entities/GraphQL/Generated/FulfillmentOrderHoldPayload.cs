#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `fulfillmentOrderHold` mutation.
/// </summary>
public record FulfillmentOrderHoldPayload : IGraphQLObject
{
    /// <summary>
    /// The fulfillment hold created for the fulfillment order. Null if no hold was created.
    /// </summary>
    [JsonPropertyName("fulfillmentHold")]
    public FulfillmentHold? fulfillmentHold { get; set; } = null;

    /// <summary>
    /// The fulfillment order on which a fulfillment hold was applied.
    /// </summary>
    [JsonPropertyName("fulfillmentOrder")]
    public FulfillmentOrder? fulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The remaining fulfillment order containing the line items to which the hold wasn't applied,
    /// if specific line items were specified to be placed on hold.
    /// </summary>
    [JsonPropertyName("remainingFulfillmentOrder")]
    public FulfillmentOrder? remainingFulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<FulfillmentOrderHoldUserError>? userErrors { get; set; } = null;
}