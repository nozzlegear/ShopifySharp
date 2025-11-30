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

public class WebhookSubscriptionConnectionQueryBuilder() : GraphQueryBuilder<WebhookSubscriptionConnection>("query webhookSubscriptionConnection")
{
    public WebhookSubscriptionConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public WebhookSubscriptionConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public WebhookSubscriptionConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}