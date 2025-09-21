#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The result of merging a set of fulfillment orders.
/// </summary>
public record FulfillmentOrderMergeResult : IGraphQLObject
{
    /// <summary>
    /// The new fulfillment order as a result of the merge.
    /// </summary>
    [JsonPropertyName("fulfillmentOrder")]
    public FulfillmentOrder? fulfillmentOrder { get; set; } = null;
}