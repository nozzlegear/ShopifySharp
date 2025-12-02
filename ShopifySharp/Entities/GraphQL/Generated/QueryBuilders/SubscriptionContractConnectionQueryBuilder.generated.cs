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

public class SubscriptionContractConnectionQueryBuilder() : GraphQueryBuilder<SubscriptionContractConnection>("subscriptionContractConnection")
{
    public SubscriptionContractConnectionQueryBuilder AddFieldEdges(Func<SubscriptionContractEdgeQueryBuilder, SubscriptionContractEdgeQueryBuilder> build)
    {
        AddField<SubscriptionContractEdge, SubscriptionContractEdgeQueryBuilder>("edges", build);
        return this;
    }

    public SubscriptionContractConnectionQueryBuilder AddFieldNodes(Func<SubscriptionContractQueryBuilder, SubscriptionContractQueryBuilder> build)
    {
        AddField<SubscriptionContract, SubscriptionContractQueryBuilder>("nodes", build);
        return this;
    }

    public SubscriptionContractConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}