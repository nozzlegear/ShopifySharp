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

public class OrderAdjustmentEdgeQueryBuilder() : GraphQueryBuilder<OrderAdjustmentEdge>("orderAdjustmentEdge")
{
    public OrderAdjustmentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public OrderAdjustmentEdgeQueryBuilder AddFieldNode(Func<OrderAdjustmentQueryBuilder, OrderAdjustmentQueryBuilder> build)
    {
        AddField<OrderAdjustment, OrderAdjustmentQueryBuilder>("node", build);
        return this;
    }
}