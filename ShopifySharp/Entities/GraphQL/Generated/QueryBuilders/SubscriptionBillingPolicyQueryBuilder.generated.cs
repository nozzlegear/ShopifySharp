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

public class SubscriptionBillingPolicyQueryBuilder() : GraphQueryBuilder<SubscriptionBillingPolicy>("subscriptionBillingPolicy")
{
    public SubscriptionBillingPolicyQueryBuilder AddFieldAnchors(Func<SellingPlanAnchorQueryBuilder, SellingPlanAnchorQueryBuilder> build)
    {
        AddField<SellingPlanAnchor, SellingPlanAnchorQueryBuilder>("anchors", build);
        return this;
    }

    public SubscriptionBillingPolicyQueryBuilder AddFieldInterval()
    {
        AddField("interval");
        return this;
    }

    public SubscriptionBillingPolicyQueryBuilder AddFieldIntervalCount()
    {
        AddField("intervalCount");
        return this;
    }

    public SubscriptionBillingPolicyQueryBuilder AddFieldMaxCycles()
    {
        AddField("maxCycles");
        return this;
    }

    public SubscriptionBillingPolicyQueryBuilder AddFieldMinCycles()
    {
        AddField("minCycles");
        return this;
    }
}