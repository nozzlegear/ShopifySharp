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

public class SubscriptionBillingCycleBulkSearchPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleBulkSearchPayload>("subscriptionBillingCycleBulkSearchPayload")
{
    public SubscriptionBillingCycleBulkSearchPayloadQueryBuilder AddFieldJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("job", build);
        return this;
    }

    public SubscriptionBillingCycleBulkSearchPayloadQueryBuilder AddFieldUserErrors(Func<SubscriptionBillingCycleBulkUserErrorQueryBuilder, SubscriptionBillingCycleBulkUserErrorQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycleBulkUserError, SubscriptionBillingCycleBulkUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}