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

public class SubscriptionBillingCycleSkipPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleSkipPayload>("subscriptionBillingCycleSkipPayload")
{
    public SubscriptionBillingCycleSkipPayloadQueryBuilder AddFieldBillingCycle(Func<SubscriptionBillingCycleQueryBuilder, SubscriptionBillingCycleQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycle, SubscriptionBillingCycleQueryBuilder>("billingCycle", build);
        return this;
    }

    public SubscriptionBillingCycleSkipPayloadQueryBuilder AddFieldUserErrors(Func<SubscriptionBillingCycleSkipUserErrorQueryBuilder, SubscriptionBillingCycleSkipUserErrorQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycleSkipUserError, SubscriptionBillingCycleSkipUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}