#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `fulfillmentServiceUpdate` mutation.
/// </summary>
public record FulfillmentServiceUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated fulfillment service.
    /// </summary>
    [JsonPropertyName("fulfillmentService")]
    public FulfillmentService? fulfillmentService { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}