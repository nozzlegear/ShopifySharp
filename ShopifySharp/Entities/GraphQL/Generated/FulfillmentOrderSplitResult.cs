#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The result of splitting a fulfillment order.
/// </summary>
public record FulfillmentOrderSplitResult : IGraphQLObject
{
    /// <summary>
    /// The original fulfillment order as a result of the split.
    /// </summary>
    [JsonPropertyName("fulfillmentOrder")]
    public FulfillmentOrder? fulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The remaining fulfillment order as a result of the split.
    /// </summary>
    [JsonPropertyName("remainingFulfillmentOrder")]
    public FulfillmentOrder? remainingFulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The replacement fulfillment order if the original fulfillment order wasn't in a state to be split.
    /// </summary>
    [JsonPropertyName("replacementFulfillmentOrder")]
    public FulfillmentOrder? replacementFulfillmentOrder { get; set; } = null;
}