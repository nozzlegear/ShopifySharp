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

public class SubscriptionBillingCyclesQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleConnection>("query subscriptionBillingCycles")
{
    public SubscriptionBillingCyclesQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public SubscriptionBillingCyclesQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public SubscriptionBillingCyclesQueryBuilder AddArgumentBillingCyclesDateRangeSelector(SubscriptionBillingCyclesDateRangeSelector? billingCyclesDateRangeSelector)
    {
        AddArgument("billingCyclesDateRangeSelector", billingCyclesDateRangeSelector);
        return this;
    }

    public SubscriptionBillingCyclesQueryBuilder AddArgumentBillingCyclesIndexRangeSelector(SubscriptionBillingCyclesIndexRangeSelector? billingCyclesIndexRangeSelector)
    {
        AddArgument("billingCyclesIndexRangeSelector", billingCyclesIndexRangeSelector);
        return this;
    }

    public SubscriptionBillingCyclesQueryBuilder AddArgumentContractId(string? contractId)
    {
        AddArgument("contractId", contractId);
        return this;
    }

    public SubscriptionBillingCyclesQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public SubscriptionBillingCyclesQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public SubscriptionBillingCyclesQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public SubscriptionBillingCyclesQueryBuilder AddArgumentSortKey(SubscriptionBillingCyclesSortKeys? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }
}