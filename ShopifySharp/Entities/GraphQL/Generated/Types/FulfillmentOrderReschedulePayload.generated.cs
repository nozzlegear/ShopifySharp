#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `fulfillmentOrderReschedule` mutation.
/// </summary>
public record FulfillmentOrderReschedulePayload : IGraphQLObject
{
    /// <summary>
    /// A fulfillment order with the rescheduled line items.
    /// Fulfillment orders may be merged if they have the same `fulfillAt` datetime.
    /// If the fulfillment order is merged then the resulting fulfillment order will be returned.
    /// Otherwise the original fulfillment order will be returned with an updated `fulfillAt` datetime.
    /// </summary>
    [JsonPropertyName("fulfillmentOrder")]
    public FulfillmentOrder? fulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<FulfillmentOrderRescheduleUserError>? userErrors { get; set; } = null;
}