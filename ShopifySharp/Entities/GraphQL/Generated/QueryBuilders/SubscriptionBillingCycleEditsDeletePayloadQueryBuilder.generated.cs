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

public class SubscriptionBillingCycleEditsDeletePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleEditsDeletePayload>("subscriptionBillingCycleEditsDeletePayload")
{
    public SubscriptionBillingCycleEditsDeletePayloadQueryBuilder AddFieldBillingCycles(Func<SubscriptionBillingCycleQueryBuilder, SubscriptionBillingCycleQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycle, SubscriptionBillingCycleQueryBuilder>("billingCycles", build);
        return this;
    }

    public SubscriptionBillingCycleEditsDeletePayloadQueryBuilder AddFieldUserErrors(Func<SubscriptionBillingCycleUserErrorQueryBuilder, SubscriptionBillingCycleUserErrorQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycleUserError, SubscriptionBillingCycleUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}