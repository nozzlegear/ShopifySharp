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

public class WebhookSubscriptionQueryBuilder() : GraphQueryBuilder<WebhookSubscription>("query webhookSubscription")
{
    public WebhookSubscriptionQueryBuilder AddFieldApiVersion()
    {
        AddField("apiVersion");
        return this;
    }

    [Obsolete("Use `uri` instead.")]
    public WebhookSubscriptionQueryBuilder AddFieldCallbackUrl()
    {
        AddField("callbackUrl");
        return this;
    }

    public WebhookSubscriptionQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    [Obsolete("Use `uri` instead.")]
    public WebhookSubscriptionQueryBuilder AddFieldEndpoint()
    {
        AddField("endpoint");
        return this;
    }

    public WebhookSubscriptionQueryBuilder AddFieldFilter()
    {
        AddField("filter");
        return this;
    }

    public WebhookSubscriptionQueryBuilder AddFieldFormat()
    {
        AddField("format");
        return this;
    }

    public WebhookSubscriptionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public WebhookSubscriptionQueryBuilder AddFieldIncludeFields()
    {
        AddField("includeFields");
        return this;
    }

    public WebhookSubscriptionQueryBuilder AddFieldLegacyResourceId()
    {
        AddField("legacyResourceId");
        return this;
    }

    public WebhookSubscriptionQueryBuilder AddFieldMetafieldNamespaces()
    {
        AddField("metafieldNamespaces");
        return this;
    }

    public WebhookSubscriptionQueryBuilder AddFieldMetafields()
    {
        AddField("metafields");
        return this;
    }

    public WebhookSubscriptionQueryBuilder AddFieldTopic()
    {
        AddField("topic");
        return this;
    }

    public WebhookSubscriptionQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}