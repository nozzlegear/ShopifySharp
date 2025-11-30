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

public class SubscriptionBillingCycleUnskipPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleUnskipPayload>("subscriptionBillingCycleUnskipPayload")
{
    public SubscriptionBillingCycleUnskipPayloadQueryBuilder AddFieldBillingCycle(Func<SubscriptionBillingCycleQueryBuilder, SubscriptionBillingCycleQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycle, SubscriptionBillingCycleQueryBuilder>("billingCycle", build);
        return this;
    }

    public SubscriptionBillingCycleUnskipPayloadQueryBuilder AddFieldUserErrors(Func<SubscriptionBillingCycleUnskipUserErrorQueryBuilder, SubscriptionBillingCycleUnskipUserErrorQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycleUnskipUserError, SubscriptionBillingCycleUnskipUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}