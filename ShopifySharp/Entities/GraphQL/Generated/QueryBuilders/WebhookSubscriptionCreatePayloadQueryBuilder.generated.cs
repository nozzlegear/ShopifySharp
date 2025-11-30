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

public class WebhookSubscriptionCreatePayloadQueryBuilder() : GraphQueryBuilder<WebhookSubscriptionCreatePayload>("webhookSubscriptionCreatePayload")
{
    public WebhookSubscriptionCreatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }

    public WebhookSubscriptionCreatePayloadQueryBuilder AddFieldWebhookSubscription(Func<WebhookSubscriptionQueryBuilder, WebhookSubscriptionQueryBuilder> build)
    {
        AddField<WebhookSubscription, WebhookSubscriptionQueryBuilder>("webhookSubscription", build);
        return this;
    }
}