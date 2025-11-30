#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

[Obsolete("Use `webhookSubscriptionCreate` instead.")]
public class EventBridgeWebhookSubscriptionCreateQueryBuilder() : GraphQueryBuilder<EventBridgeWebhookSubscriptionCreatePayload>("query eventBridgeWebhookSubscriptionCreate")
{
    public EventBridgeWebhookSubscriptionCreateQueryBuilder AddArgumentTopic(WebhookSubscriptionTopic? topic)
    {
        AddArgument("topic", topic);
        return this;
    }

    public EventBridgeWebhookSubscriptionCreateQueryBuilder AddArgumentWebhookSubscription(EventBridgeWebhookSubscriptionInput? webhookSubscription)
    {
        AddArgument("webhookSubscription", webhookSubscription);
        return this;
    }
}