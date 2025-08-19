#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A Google Cloud Pub/Sub topic to which webhook subscriptions publish events.
/// </summary>
public record WebhookPubSubEndpoint : WebhookSubscriptionEndpoint, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The Google Cloud Pub/Sub project ID.
    /// </summary>
    [JsonPropertyName("pubSubProject")]
    public string? pubSubProject { get; set; } = null;

    /// <summary>
    /// The Google Cloud Pub/Sub topic ID.
    /// </summary>
    [JsonPropertyName("pubSubTopic")]
    public string? pubSubTopic { get; set; } = null;
}