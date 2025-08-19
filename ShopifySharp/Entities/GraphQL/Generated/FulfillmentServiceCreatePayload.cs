#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `fulfillmentServiceCreate` mutation.
/// </summary>
public record FulfillmentServiceCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created fulfillment service.
    /// </summary>
    [JsonPropertyName("fulfillmentService")]
    public FulfillmentService? fulfillmentService { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}