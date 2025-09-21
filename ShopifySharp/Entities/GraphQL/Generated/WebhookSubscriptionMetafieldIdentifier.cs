#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Identifies metafields by their namespace, and key.
/// </summary>
public record WebhookSubscriptionMetafieldIdentifier : IGraphQLObject
{
    /// <summary>
    /// The unique identifier for the metafield definition within its namespace.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The container for a group of metafields that the metafield definition is associated with.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;
}