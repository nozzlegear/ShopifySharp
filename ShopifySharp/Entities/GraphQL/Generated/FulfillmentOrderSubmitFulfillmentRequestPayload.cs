#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `fulfillmentOrderSubmitFulfillmentRequest` mutation.
/// </summary>
public record FulfillmentOrderSubmitFulfillmentRequestPayload : IGraphQLObject
{
    /// <summary>
    /// The original fulfillment order intended to request fulfillment for.
    /// </summary>
    [JsonPropertyName("originalFulfillmentOrder")]
    public FulfillmentOrder? originalFulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The fulfillment order that was submitted to the fulfillment service. This will be the same as
    /// the original fulfillment order field. The exception to this is partial fulfillment requests or
    /// fulfillment request for cancelled or incomplete fulfillment orders.
    /// </summary>
    [JsonPropertyName("submittedFulfillmentOrder")]
    public FulfillmentOrder? submittedFulfillmentOrder { get; set; } = null;

    /// <summary>
    /// This field will only be present for partial fulfillment requests. This will represent the new
    /// fulfillment order with the remaining line items not submitted to the fulfillment service.
    /// </summary>
    [JsonPropertyName("unsubmittedFulfillmentOrder")]
    public FulfillmentOrder? unsubmittedFulfillmentOrder { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}