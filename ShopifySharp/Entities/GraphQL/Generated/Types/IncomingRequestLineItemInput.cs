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
/// The input fields for the incoming line item.
/// </summary>
public record IncomingRequestLineItemInput : GraphQLInputObject<IncomingRequestLineItemInput>
{
    /// <summary>
    /// The ID of the rejected line item.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderLineItemId")]
    public string? fulfillmentOrderLineItemId { get; set; } = null;

    /// <summary>
    /// The rejection message of the line item.
    /// </summary>
    [JsonPropertyName("message")]
    public string? message { get; set; } = null;
}