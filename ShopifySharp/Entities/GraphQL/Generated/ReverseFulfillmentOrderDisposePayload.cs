#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `reverseFulfillmentOrderDispose` mutation.
/// </summary>
public record ReverseFulfillmentOrderDisposePayload : IGraphQLObject
{
    /// <summary>
    /// The disposed reverse fulfillment order line items.
    /// </summary>
    [JsonPropertyName("reverseFulfillmentOrderLineItems")]
    public ICollection<ReverseFulfillmentOrderLineItem>? reverseFulfillmentOrderLineItems { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<ReturnUserError>? userErrors { get; set; } = null;
}