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
public class PubSubWebhookSubscriptionCreateQueryBuilder() : GraphQueryBuilder<PubSubWebhookSubscriptionCreatePayload>("query pubSubWebhookSubscriptionCreate")
{
    public PubSubWebhookSubscriptionCreateQueryBuilder AddArgumentTopic(WebhookSubscriptionTopic? topic)
    {
        AddArgument("topic", topic);
        return this;
    }

    public PubSubWebhookSubscriptionCreateQueryBuilder AddArgumentWebhookSubscription(PubSubWebhookSubscriptionInput? webhookSubscription)
    {
        AddArgument("webhookSubscription", webhookSubscription);
        return this;
    }
}