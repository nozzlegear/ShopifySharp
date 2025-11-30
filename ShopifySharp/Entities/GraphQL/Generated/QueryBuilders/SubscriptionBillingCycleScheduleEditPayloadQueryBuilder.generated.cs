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

public class SubscriptionBillingCycleScheduleEditPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleScheduleEditPayload>("subscriptionBillingCycleScheduleEditPayload")
{
    public SubscriptionBillingCycleScheduleEditPayloadQueryBuilder AddFieldBillingCycle(Func<SubscriptionBillingCycleQueryBuilder, SubscriptionBillingCycleQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycle, SubscriptionBillingCycleQueryBuilder>("billingCycle", build);
        return this;
    }

    public SubscriptionBillingCycleScheduleEditPayloadQueryBuilder AddFieldUserErrors(Func<SubscriptionBillingCycleUserErrorQueryBuilder, SubscriptionBillingCycleUserErrorQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycleUserError, SubscriptionBillingCycleUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}