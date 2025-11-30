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

public class SubscriptionBillingCycleEdgeQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleEdge>("subscriptionBillingCycleEdge")
{
    public SubscriptionBillingCycleEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SubscriptionBillingCycleEdgeQueryBuilder AddFieldNode(Func<SubscriptionBillingCycleQueryBuilder, SubscriptionBillingCycleQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycle, SubscriptionBillingCycleQueryBuilder>("node", build);
        return this;
    }
}