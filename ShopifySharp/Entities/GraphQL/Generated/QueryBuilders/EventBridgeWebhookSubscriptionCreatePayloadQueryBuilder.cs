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

public class EventBridgeWebhookSubscriptionCreatePayloadQueryBuilder() : GraphQueryBuilder<EventBridgeWebhookSubscriptionCreatePayload>("query eventBridgeWebhookSubscriptionCreatePayload")
{
    public EventBridgeWebhookSubscriptionCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }

    public EventBridgeWebhookSubscriptionCreatePayloadQueryBuilder AddFieldWebhookSubscription()
    {
        AddField("webhookSubscription");
        return this;
    }
}