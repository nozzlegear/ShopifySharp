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

public class RefundShippingLineConnectionQueryBuilder() : GraphQueryBuilder<RefundShippingLineConnection>("refundShippingLineConnection")
{
    public RefundShippingLineConnectionQueryBuilder AddFieldEdges(Func<RefundShippingLineEdgeQueryBuilder, RefundShippingLineEdgeQueryBuilder> build)
    {
        AddField<RefundShippingLineEdge, RefundShippingLineEdgeQueryBuilder>("edges", build);
        return this;
    }

    public RefundShippingLineConnectionQueryBuilder AddFieldNodes(Func<RefundShippingLineQueryBuilder, RefundShippingLineQueryBuilder> build)
    {
        AddField<RefundShippingLine, RefundShippingLineQueryBuilder>("nodes", build);
        return this;
    }

    public RefundShippingLineConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}