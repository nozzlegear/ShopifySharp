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

public class SubscriptionDiscountConnectionQueryBuilder() : GraphQueryBuilder<SubscriptionDiscountConnection>("query subscriptionDiscountConnection")
{
    public SubscriptionDiscountConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public SubscriptionDiscountConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public SubscriptionDiscountConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}