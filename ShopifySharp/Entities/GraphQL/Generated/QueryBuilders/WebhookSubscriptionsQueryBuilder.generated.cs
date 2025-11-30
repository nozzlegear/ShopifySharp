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

public class WebhookSubscriptionsQueryBuilder() : GraphQueryBuilder<WebhookSubscriptionConnection>("webhookSubscriptions"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public WebhookSubscriptionsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public WebhookSubscriptionsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public WebhookSubscriptionsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public WebhookSubscriptionsQueryBuilder AddArgumentFormat(WebhookSubscriptionFormat? format)
    {
        AddArgument("format", format);
        return this;
    }

    public WebhookSubscriptionsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public WebhookSubscriptionsQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public WebhookSubscriptionsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public WebhookSubscriptionsQueryBuilder AddArgumentSortKey(WebhookSubscriptionSortKeys? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }

    public WebhookSubscriptionsQueryBuilder AddArgumentTopics(ICollection<WebhookSubscriptionTopic>? topics)
    {
        AddArgument("topics", topics);
        return this;
    }
}