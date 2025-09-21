#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for merging fulfillment orders.
/// </summary>
public record FulfillmentOrderMergeInput : GraphQLInputObject<FulfillmentOrderMergeInput>
{
    /// <summary>
    /// The details of the fulfillment orders to be merged.
    /// </summary>
    [JsonPropertyName("mergeIntents")]
    public ICollection<FulfillmentOrderMergeInputMergeIntent>? mergeIntents { get; set; } = null;
}