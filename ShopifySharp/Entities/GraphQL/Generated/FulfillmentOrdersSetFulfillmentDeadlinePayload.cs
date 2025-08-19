#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `fulfillmentOrdersSetFulfillmentDeadline` mutation.
/// </summary>
public record FulfillmentOrdersSetFulfillmentDeadlinePayload : IGraphQLObject
{
    /// <summary>
    /// Whether the fulfillment deadline was successfully set.
    /// </summary>
    [JsonPropertyName("success")]
    public bool? success { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<FulfillmentOrdersSetFulfillmentDeadlineUserError>? userErrors { get; set; } = null;
}