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

public class SubscriptionBillingCycleBulkResultsQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleConnection>("subscriptionBillingCycleBulkResults"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public SubscriptionBillingCycleBulkResultsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public SubscriptionBillingCycleBulkResultsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public SubscriptionBillingCycleBulkResultsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public SubscriptionBillingCycleBulkResultsQueryBuilder AddArgumentJobId(string? jobId)
    {
        AddArgument("jobId", jobId);
        return this;
    }

    public SubscriptionBillingCycleBulkResultsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public SubscriptionBillingCycleBulkResultsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }
}