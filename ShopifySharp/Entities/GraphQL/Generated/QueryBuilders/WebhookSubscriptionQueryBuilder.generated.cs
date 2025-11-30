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

public class WebhookSubscriptionQueryBuilder() : GraphQueryBuilder<WebhookSubscription>("webhookSubscription")
{
    public WebhookSubscriptionQueryBuilder AddFieldApiVersion(Func<ApiVersionQueryBuilder, ApiVersionQueryBuilder> build)
    {
        AddField<ApiVersion, ApiVersionQueryBuilder>("apiVersion", build);
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

    public WebhookSubscriptionQueryBuilder AddUnionCaseEndpoint(Func<WebhookEventBridgeEndpointQueryBuilder, WebhookEventBridgeEndpointQueryBuilder> build)
    {
        AddUnion<WebhookEventBridgeEndpoint, WebhookEventBridgeEndpointQueryBuilder>("endpoint", build);
        return this;
    }

    public WebhookSubscriptionQueryBuilder AddUnionCaseEndpoint(Func<WebhookHttpEndpointQueryBuilder, WebhookHttpEndpointQueryBuilder> build)
    {
        AddUnion<WebhookHttpEndpoint, WebhookHttpEndpointQueryBuilder>("endpoint", build);
        return this;
    }

    public WebhookSubscriptionQueryBuilder AddUnionCaseEndpoint(Func<WebhookPubSubEndpointQueryBuilder, WebhookPubSubEndpointQueryBuilder> build)
    {
        AddUnion<WebhookPubSubEndpoint, WebhookPubSubEndpointQueryBuilder>("endpoint", build);
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

    public WebhookSubscriptionQueryBuilder AddFieldMetafields(Func<WebhookSubscriptionMetafieldIdentifierQueryBuilder, WebhookSubscriptionMetafieldIdentifierQueryBuilder> build)
    {
        AddField<WebhookSubscriptionMetafieldIdentifier, WebhookSubscriptionMetafieldIdentifierQueryBuilder>("metafields", build);
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