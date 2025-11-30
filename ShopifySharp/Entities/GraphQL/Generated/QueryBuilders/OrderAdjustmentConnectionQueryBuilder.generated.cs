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

public class OrderAdjustmentConnectionQueryBuilder() : GraphQueryBuilder<OrderAdjustmentConnection>("orderAdjustmentConnection")
{
    public OrderAdjustmentConnectionQueryBuilder AddFieldEdges(Func<OrderAdjustmentEdgeQueryBuilder, OrderAdjustmentEdgeQueryBuilder> build)
    {
        AddField<OrderAdjustmentEdge, OrderAdjustmentEdgeQueryBuilder>("edges", build);
        return this;
    }

    public OrderAdjustmentConnectionQueryBuilder AddFieldNodes(Func<OrderAdjustmentQueryBuilder, OrderAdjustmentQueryBuilder> build)
    {
        AddField<OrderAdjustment, OrderAdjustmentQueryBuilder>("nodes", build);
        return this;
    }

    public OrderAdjustmentConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}