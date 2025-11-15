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

public class PubSubWebhookSubscriptionCreateUserErrorQueryBuilder() : GraphQueryBuilder<PubSubWebhookSubscriptionCreateUserError>("query pubSubWebhookSubscriptionCreateUserError")
{
    public PubSubWebhookSubscriptionCreateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public PubSubWebhookSubscriptionCreateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public PubSubWebhookSubscriptionCreateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}