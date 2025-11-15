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

public class WebhookSubscriptionMetafieldIdentifierQueryBuilder() : GraphQueryBuilder<WebhookSubscriptionMetafieldIdentifier>("query webhookSubscriptionMetafieldIdentifier")
{
    public WebhookSubscriptionMetafieldIdentifierQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public WebhookSubscriptionMetafieldIdentifierQueryBuilder AddFieldNamespace()
    {
        AddField("namespace");
        return this;
    }
}