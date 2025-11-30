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

public class WebhookSubscriptionEdgeQueryBuilder() : GraphQueryBuilder<WebhookSubscriptionEdge>("webhookSubscriptionEdge")
{
    public WebhookSubscriptionEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public WebhookSubscriptionEdgeQueryBuilder AddFieldNode(Func<WebhookSubscriptionQueryBuilder, WebhookSubscriptionQueryBuilder> build)
    {
        AddField<WebhookSubscription, WebhookSubscriptionQueryBuilder>("node", build);
        return this;
    }
}