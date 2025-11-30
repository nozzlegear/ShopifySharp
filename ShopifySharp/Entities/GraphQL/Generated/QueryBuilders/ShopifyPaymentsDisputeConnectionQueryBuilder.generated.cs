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

public class ShopifyPaymentsDisputeConnectionQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsDisputeConnection>("shopifyPaymentsDisputeConnection")
{
    public ShopifyPaymentsDisputeConnectionQueryBuilder AddFieldEdges(Func<ShopifyPaymentsDisputeEdgeQueryBuilder, ShopifyPaymentsDisputeEdgeQueryBuilder> build)
    {
        AddField<ShopifyPaymentsDisputeEdge, ShopifyPaymentsDisputeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ShopifyPaymentsDisputeConnectionQueryBuilder AddFieldNodes(Func<ShopifyPaymentsDisputeQueryBuilder, ShopifyPaymentsDisputeQueryBuilder> build)
    {
        AddField<ShopifyPaymentsDispute, ShopifyPaymentsDisputeQueryBuilder>("nodes", build);
        return this;
    }

    public ShopifyPaymentsDisputeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}