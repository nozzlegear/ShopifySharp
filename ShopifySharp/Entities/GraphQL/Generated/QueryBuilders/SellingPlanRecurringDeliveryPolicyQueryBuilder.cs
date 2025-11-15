#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class SellingPlanRecurringDeliveryPolicyQueryBuilder() : GraphQueryBuilder<SellingPlanRecurringDeliveryPolicy>("query sellingPlanRecurringDeliveryPolicy")
{
    public SellingPlanRecurringDeliveryPolicyQueryBuilder AddFieldAnchors()
    {
        AddField("anchors");
        return this;
    }

    public SellingPlanRecurringDeliveryPolicyQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public SellingPlanRecurringDeliveryPolicyQueryBuilder AddFieldCutoff()
    {
        AddField("cutoff");
        return this;
    }

    public SellingPlanRecurringDeliveryPolicyQueryBuilder AddFieldIntent()
    {
        AddField("intent");
        return this;
    }

    public SellingPlanRecurringDeliveryPolicyQueryBuilder AddFieldInterval()
    {
        AddField("interval");
        return this;
    }

    public SellingPlanRecurringDeliveryPolicyQueryBuilder AddFieldIntervalCount()
    {
        AddField("intervalCount");
        return this;
    }

    public SellingPlanRecurringDeliveryPolicyQueryBuilder AddFieldPreAnchorBehavior()
    {
        AddField("preAnchorBehavior");
        return this;
    }
}