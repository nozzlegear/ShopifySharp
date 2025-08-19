#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `fulfillmentOrderCancel` mutation.
/// </summary>
public record FulfillmentOrderCancelPayload : IGraphQLObject
{
    /// <summary>
    /// The fulfillment order that was marked as canceled.
    /// </summary>
    [JsonPropertyName("fulfillmentOrder")]
    public FulfillmentOrder? fulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The fulfillment order that was created to replace the canceled fulfillment order.
    /// </summary>
    [JsonPropertyName("replacementFulfillmentOrder")]
    public FulfillmentOrder? replacementFulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}