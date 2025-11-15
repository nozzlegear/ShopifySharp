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

public class SubscriptionBillingAttemptsQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttemptConnection>("query subscriptionBillingAttempts")
{
    public SubscriptionBillingAttemptsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public SubscriptionBillingAttemptsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public SubscriptionBillingAttemptsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public SubscriptionBillingAttemptsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public SubscriptionBillingAttemptsQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public SubscriptionBillingAttemptsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public SubscriptionBillingAttemptsQueryBuilder AddArgumentSortKey(SubscriptionBillingAttemptsSortKeys? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }
}