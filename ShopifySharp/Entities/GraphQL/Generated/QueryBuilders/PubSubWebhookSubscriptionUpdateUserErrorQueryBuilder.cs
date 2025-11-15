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

public class PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder() : GraphQueryBuilder<PubSubWebhookSubscriptionUpdateUserError>("query pubSubWebhookSubscriptionUpdateUserError")
{
    public PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}