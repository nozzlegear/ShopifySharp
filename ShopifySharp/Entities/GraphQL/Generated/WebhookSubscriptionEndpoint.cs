#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An endpoint to which webhook subscriptions send webhooks events.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(WebhookSubscriptionEndpointWebhookEventBridgeEndpoint), typeDiscriminator: "WebhookEventBridgeEndpoint")]
[JsonDerivedType(typeof(WebhookSubscriptionEndpointWebhookHttpEndpoint), typeDiscriminator: "WebhookHttpEndpoint")]
[JsonDerivedType(typeof(WebhookSubscriptionEndpointWebhookPubSubEndpoint), typeDiscriminator: "WebhookPubSubEndpoint")]
public record WebhookSubscriptionEndpoint : GraphQLObject<WebhookSubscriptionEndpoint>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public WebhookEventBridgeEndpoint? AsWebhookEventBridgeEndpoint() => this is WebhookSubscriptionEndpointWebhookEventBridgeEndpoint wrapper ? wrapper.Value : null;
	public WebhookHttpEndpoint? AsWebhookHttpEndpoint() => this is WebhookSubscriptionEndpointWebhookHttpEndpoint wrapper ? wrapper.Value : null;
	public WebhookPubSubEndpoint? AsWebhookPubSubEndpoint() => this is WebhookSubscriptionEndpointWebhookPubSubEndpoint wrapper ? wrapper.Value : null;
#endif
}