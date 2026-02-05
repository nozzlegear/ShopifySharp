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
/// An endpoint to which webhook subscriptions send webhooks events.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<WebhookSubscriptionEndpoint>))]
public record WebhookSubscriptionEndpoint : GraphQLObject<WebhookSubscriptionEndpoint>, IGraphQLUnionType
{
    public WebhookEventBridgeEndpoint? AsWebhookEventBridgeEndpoint() => this is WebhookSubscriptionEndpointWebhookEventBridgeEndpoint wrapper ? wrapper.Value : null;
    public WebhookHttpEndpoint? AsWebhookHttpEndpoint() => this is WebhookSubscriptionEndpointWebhookHttpEndpoint wrapper ? wrapper.Value : null;
    public WebhookPubSubEndpoint? AsWebhookPubSubEndpoint() => this is WebhookSubscriptionEndpointWebhookPubSubEndpoint wrapper ? wrapper.Value : null;
}