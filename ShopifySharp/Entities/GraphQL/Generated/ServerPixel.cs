#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A server pixel stores configuration for streaming customer interactions to an EventBridge or PubSub endpoint.
/// </summary>
public record ServerPixel : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The current state of this server pixel.
    /// </summary>
    [JsonPropertyName("status")]
    public ServerPixelStatus? status { get; set; } = null;

    /// <summary>
    /// Address of the EventBridge or PubSub endpoint.
    /// </summary>
    [JsonPropertyName("webhookEndpointAddress")]
    public string? webhookEndpointAddress { get; set; } = null;
}