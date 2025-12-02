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

public class SubscriptionDeliveryPolicyQueryBuilder() : GraphQueryBuilder<SubscriptionDeliveryPolicy>("subscriptionDeliveryPolicy")
{
    public SubscriptionDeliveryPolicyQueryBuilder AddFieldAnchors(Func<SellingPlanAnchorQueryBuilder, SellingPlanAnchorQueryBuilder> build)
    {
        AddField<SellingPlanAnchor, SellingPlanAnchorQueryBuilder>("anchors", build);
        return this;
    }

    public SubscriptionDeliveryPolicyQueryBuilder AddFieldInterval()
    {
        AddField("interval");
        return this;
    }

    public SubscriptionDeliveryPolicyQueryBuilder AddFieldIntervalCount()
    {
        AddField("intervalCount");
        return this;
    }
}