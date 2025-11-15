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

public class EventBridgeWebhookSubscriptionUpdatePayloadQueryBuilder() : GraphQueryBuilder<EventBridgeWebhookSubscriptionUpdatePayload>("query eventBridgeWebhookSubscriptionUpdatePayload")
{
    public EventBridgeWebhookSubscriptionUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }

    public EventBridgeWebhookSubscriptionUpdatePayloadQueryBuilder AddFieldWebhookSubscription()
    {
        AddField("webhookSubscription");
        return this;
    }
}