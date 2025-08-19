#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `fulfillmentOrderLineItemsPreparedForPickup` mutation.
/// </summary>
public record FulfillmentOrderLineItemsPreparedForPickupPayload : IGraphQLObject
{
    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<FulfillmentOrderLineItemsPreparedForPickupUserError>? userErrors { get; set; } = null;
}