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

public class RefundLineItemConnectionQueryBuilder() : GraphQueryBuilder<RefundLineItemConnection>("refundLineItemConnection")
{
    public RefundLineItemConnectionQueryBuilder AddFieldEdges(Func<RefundLineItemEdgeQueryBuilder, RefundLineItemEdgeQueryBuilder> build)
    {
        AddField<RefundLineItemEdge, RefundLineItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public RefundLineItemConnectionQueryBuilder AddFieldNodes(Func<RefundLineItemQueryBuilder, RefundLineItemQueryBuilder> build)
    {
        AddField<RefundLineItem, RefundLineItemQueryBuilder>("nodes", build);
        return this;
    }

    public RefundLineItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}