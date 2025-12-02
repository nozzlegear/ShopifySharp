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

public class SubscriptionBillingCycleBulkChargePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleBulkChargePayload>("subscriptionBillingCycleBulkChargePayload")
{
    public SubscriptionBillingCycleBulkChargePayloadQueryBuilder AddFieldJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("job", build);
        return this;
    }

    public SubscriptionBillingCycleBulkChargePayloadQueryBuilder AddFieldUserErrors(Func<SubscriptionBillingCycleBulkUserErrorQueryBuilder, SubscriptionBillingCycleBulkUserErrorQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycleBulkUserError, SubscriptionBillingCycleBulkUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}