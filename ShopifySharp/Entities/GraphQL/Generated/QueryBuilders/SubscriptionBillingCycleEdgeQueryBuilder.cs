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

public class SubscriptionBillingCycleEdgeQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleEdge>("query subscriptionBillingCycleEdge")
{
    public SubscriptionBillingCycleEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SubscriptionBillingCycleEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}