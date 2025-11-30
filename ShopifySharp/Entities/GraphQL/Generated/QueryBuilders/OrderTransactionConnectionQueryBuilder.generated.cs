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

public class OrderTransactionConnectionQueryBuilder() : GraphQueryBuilder<OrderTransactionConnection>("orderTransactionConnection")
{
    public OrderTransactionConnectionQueryBuilder AddFieldEdges(Func<OrderTransactionEdgeQueryBuilder, OrderTransactionEdgeQueryBuilder> build)
    {
        AddField<OrderTransactionEdge, OrderTransactionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public OrderTransactionConnectionQueryBuilder AddFieldNodes(Func<OrderTransactionQueryBuilder, OrderTransactionQueryBuilder> build)
    {
        AddField<OrderTransaction, OrderTransactionQueryBuilder>("nodes", build);
        return this;
    }

    public OrderTransactionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}