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

public class SubscriptionDiscountEdgeQueryBuilder() : GraphQueryBuilder<SubscriptionDiscountEdge>("query subscriptionDiscountEdge")
{
    public SubscriptionDiscountEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SubscriptionDiscountEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}