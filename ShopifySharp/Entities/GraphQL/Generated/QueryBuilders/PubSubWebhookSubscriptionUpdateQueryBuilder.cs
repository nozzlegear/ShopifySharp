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
public class PubSubWebhookSubscriptionUpdateQueryBuilder() : GraphQueryBuilder<PubSubWebhookSubscriptionUpdatePayload>("query pubSubWebhookSubscriptionUpdate")
{
    public PubSubWebhookSubscriptionUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public PubSubWebhookSubscriptionUpdateQueryBuilder AddArgumentWebhookSubscription(PubSubWebhookSubscriptionInput? webhookSubscription)
    {
        AddArgument("webhookSubscription", webhookSubscription);
        return this;
    }
}