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

public class SubscriptionBillingCycleBulkChargeQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleBulkChargePayload>("query subscriptionBillingCycleBulkCharge")
{
    public SubscriptionBillingCycleBulkChargeQueryBuilder AddArgumentBillingAttemptExpectedDateRange(SubscriptionBillingCyclesDateRangeSelector? billingAttemptExpectedDateRange)
    {
        AddArgument("billingAttemptExpectedDateRange", billingAttemptExpectedDateRange);
        return this;
    }

    public SubscriptionBillingCycleBulkChargeQueryBuilder AddArgumentFilters(SubscriptionBillingCycleBulkFilters? filters)
    {
        AddArgument("filters", filters);
        return this;
    }

    public SubscriptionBillingCycleBulkChargeQueryBuilder AddArgumentInventoryPolicy(SubscriptionBillingAttemptInventoryPolicy? inventoryPolicy)
    {
        AddArgument("inventoryPolicy", inventoryPolicy);
        return this;
    }
}