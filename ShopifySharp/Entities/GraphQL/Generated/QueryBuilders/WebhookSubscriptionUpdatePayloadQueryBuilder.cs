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

public class WebhookSubscriptionUpdatePayloadQueryBuilder() : GraphQueryBuilder<WebhookSubscriptionUpdatePayload>("query webhookSubscriptionUpdatePayload")
{
    public WebhookSubscriptionUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }

    public WebhookSubscriptionUpdatePayloadQueryBuilder AddFieldWebhookSubscription()
    {
        AddField("webhookSubscription");
        return this;
    }
}