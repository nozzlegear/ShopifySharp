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

public class WebhookSubscriptionDeletePayloadQueryBuilder() : GraphQueryBuilder<WebhookSubscriptionDeletePayload>("query webhookSubscriptionDeletePayload")
{
    public WebhookSubscriptionDeletePayloadQueryBuilder AddFieldDeletedWebhookSubscriptionId()
    {
        AddField("deletedWebhookSubscriptionId");
        return this;
    }

    public WebhookSubscriptionDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}