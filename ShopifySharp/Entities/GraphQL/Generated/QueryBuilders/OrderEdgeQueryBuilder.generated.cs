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

public class OrderEdgeQueryBuilder() : GraphQueryBuilder<OrderEdge>("orderEdge")
{
    public OrderEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public OrderEdgeQueryBuilder AddFieldNode(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("node", build);
        return this;
    }
}