#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An Amazon EventBridge partner event source to which webhook subscriptions publish events.
/// </summary>
public record WebhookEventBridgeEndpoint : WebhookSubscriptionEndpoint, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The ARN of this EventBridge partner event source.
    /// </summary>
    [JsonPropertyName("arn")]
    public string? arn { get; set; } = null;
}