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

public class SellingPlanRecurringBillingPolicyQueryBuilder() : GraphQueryBuilder<SellingPlanRecurringBillingPolicy>("query sellingPlanRecurringBillingPolicy")
{
    public SellingPlanRecurringBillingPolicyQueryBuilder AddFieldAnchors()
    {
        AddField("anchors");
        return this;
    }

    public SellingPlanRecurringBillingPolicyQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public SellingPlanRecurringBillingPolicyQueryBuilder AddFieldInterval()
    {
        AddField("interval");
        return this;
    }

    public SellingPlanRecurringBillingPolicyQueryBuilder AddFieldIntervalCount()
    {
        AddField("intervalCount");
        return this;
    }

    public SellingPlanRecurringBillingPolicyQueryBuilder AddFieldMaxCycles()
    {
        AddField("maxCycles");
        return this;
    }

    public SellingPlanRecurringBillingPolicyQueryBuilder AddFieldMinCycles()
    {
        AddField("minCycles");
        return this;
    }
}