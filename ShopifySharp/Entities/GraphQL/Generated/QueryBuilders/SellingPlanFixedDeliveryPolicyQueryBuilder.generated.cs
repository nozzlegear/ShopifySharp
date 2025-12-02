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

public class SellingPlanFixedDeliveryPolicyQueryBuilder() : GraphQueryBuilder<SellingPlanFixedDeliveryPolicy>("sellingPlanFixedDeliveryPolicy")
{
    public SellingPlanFixedDeliveryPolicyQueryBuilder AddFieldAnchors(Func<SellingPlanAnchorQueryBuilder, SellingPlanAnchorQueryBuilder> build)
    {
        AddField<SellingPlanAnchor, SellingPlanAnchorQueryBuilder>("anchors", build);
        return this;
    }

    public SellingPlanFixedDeliveryPolicyQueryBuilder AddFieldCutoff()
    {
        AddField("cutoff");
        return this;
    }

    public SellingPlanFixedDeliveryPolicyQueryBuilder AddFieldFulfillmentExactTime()
    {
        AddField("fulfillmentExactTime");
        return this;
    }

    public SellingPlanFixedDeliveryPolicyQueryBuilder AddFieldFulfillmentTrigger()
    {
        AddField("fulfillmentTrigger");
        return this;
    }

    public SellingPlanFixedDeliveryPolicyQueryBuilder AddFieldIntent()
    {
        AddField("intent");
        return this;
    }

    public SellingPlanFixedDeliveryPolicyQueryBuilder AddFieldPreAnchorBehavior()
    {
        AddField("preAnchorBehavior");
        return this;
    }
}