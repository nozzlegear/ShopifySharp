#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record WebhookSubscriptionEndpointWebhookEventBridgeEndpoint(WebhookEventBridgeEndpoint Value): WebhookSubscriptionEndpoint;
internal record WebhookSubscriptionEndpointWebhookHttpEndpoint(WebhookHttpEndpoint Value): WebhookSubscriptionEndpoint;
internal record WebhookSubscriptionEndpointWebhookPubSubEndpoint(WebhookPubSubEndpoint Value): WebhookSubscriptionEndpoint;
#endif /// <summary>

/// The supported formats for webhook subscriptions.
/// </summary>
public enum WebhookSubscriptionFormat
{
    JSON,
    XML,
}