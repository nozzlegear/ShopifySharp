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

public class SubscriptionBillingCycleBulkSearchQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleBulkSearchPayload>("query subscriptionBillingCycleBulkSearch")
{
    public SubscriptionBillingCycleBulkSearchQueryBuilder AddArgumentBillingAttemptExpectedDateRange(SubscriptionBillingCyclesDateRangeSelector? billingAttemptExpectedDateRange)
    {
        AddArgument("billingAttemptExpectedDateRange", billingAttemptExpectedDateRange);
        return this;
    }

    public SubscriptionBillingCycleBulkSearchQueryBuilder AddArgumentFilters(SubscriptionBillingCycleBulkFilters? filters)
    {
        AddArgument("filters", filters);
        return this;
    }
}