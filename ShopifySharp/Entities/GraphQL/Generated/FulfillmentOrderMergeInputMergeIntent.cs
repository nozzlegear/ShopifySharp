#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for merging fulfillment orders into a single merged fulfillment order.
/// </summary>
public record FulfillmentOrderMergeInputMergeIntent : GraphQLInputObject<FulfillmentOrderMergeInputMergeIntent>
{
    /// <summary>
    /// The ID of the fulfillment order to be merged.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderId")]
    public string? fulfillmentOrderId { get; set; } = null;

    /// <summary>
    /// The fulfillment order line items to be merged.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderLineItems")]
    public ICollection<FulfillmentOrderLineItemInput>? fulfillmentOrderLineItems { get; set; } = null;
}