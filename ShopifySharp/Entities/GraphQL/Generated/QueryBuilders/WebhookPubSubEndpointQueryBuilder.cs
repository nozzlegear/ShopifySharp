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

public class WebhookPubSubEndpointQueryBuilder() : GraphQueryBuilder<WebhookPubSubEndpoint>("query webhookPubSubEndpoint")
{
    public WebhookPubSubEndpointQueryBuilder AddFieldPubSubProject()
    {
        AddField("pubSubProject");
        return this;
    }

    public WebhookPubSubEndpointQueryBuilder AddFieldPubSubTopic()
    {
        AddField("pubSubTopic");
        return this;
    }
}