#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class WebhookSubscriptionConnectionQueryBuilder() : GraphQueryBuilder<WebhookSubscriptionConnection>("webhookSubscriptionConnection")
{
    public WebhookSubscriptionConnectionQueryBuilder AddFieldEdges(Func<WebhookSubscriptionEdgeQueryBuilder, WebhookSubscriptionEdgeQueryBuilder> build)
    {
        AddField<WebhookSubscriptionEdge, WebhookSubscriptionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public WebhookSubscriptionConnectionQueryBuilder AddFieldNodes(Func<WebhookSubscriptionQueryBuilder, WebhookSubscriptionQueryBuilder> build)
    {
        AddField<WebhookSubscription, WebhookSubscriptionQueryBuilder>("nodes", build);
        return this;
    }

    public WebhookSubscriptionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}