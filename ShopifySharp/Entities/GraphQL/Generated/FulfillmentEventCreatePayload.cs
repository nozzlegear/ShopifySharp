#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `fulfillmentEventCreate` mutation.
/// </summary>
public record FulfillmentEventCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created fulfillment event.
    /// </summary>
    [JsonPropertyName("fulfillmentEvent")]
    public FulfillmentEvent? fulfillmentEvent { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}