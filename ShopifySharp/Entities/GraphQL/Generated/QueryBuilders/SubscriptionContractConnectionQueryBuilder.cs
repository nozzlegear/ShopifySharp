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

public class SubscriptionContractConnectionQueryBuilder() : GraphQueryBuilder<SubscriptionContractConnection>("query subscriptionContractConnection")
{
    public SubscriptionContractConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public SubscriptionContractConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public SubscriptionContractConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}