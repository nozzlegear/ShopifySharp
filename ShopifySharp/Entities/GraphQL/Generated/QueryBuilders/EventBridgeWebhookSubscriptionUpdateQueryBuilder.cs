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

[Obsolete("Use `webhookSubscriptionUpdate` instead.")]
public class EventBridgeWebhookSubscriptionUpdateQueryBuilder() : GraphQueryBuilder<EventBridgeWebhookSubscriptionUpdatePayload>("query eventBridgeWebhookSubscriptionUpdate")
{
    public EventBridgeWebhookSubscriptionUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public EventBridgeWebhookSubscriptionUpdateQueryBuilder AddArgumentWebhookSubscription(EventBridgeWebhookSubscriptionInput? webhookSubscription)
    {
        AddArgument("webhookSubscription", webhookSubscription);
        return this;
    }
}