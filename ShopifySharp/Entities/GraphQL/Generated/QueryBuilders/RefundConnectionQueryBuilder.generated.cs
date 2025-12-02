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

public class RefundConnectionQueryBuilder() : GraphQueryBuilder<RefundConnection>("refundConnection")
{
    public RefundConnectionQueryBuilder AddFieldEdges(Func<RefundEdgeQueryBuilder, RefundEdgeQueryBuilder> build)
    {
        AddField<RefundEdge, RefundEdgeQueryBuilder>("edges", build);
        return this;
    }

    public RefundConnectionQueryBuilder AddFieldNodes(Func<RefundQueryBuilder, RefundQueryBuilder> build)
    {
        AddField<Refund, RefundQueryBuilder>("nodes", build);
        return this;
    }

    public RefundConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}