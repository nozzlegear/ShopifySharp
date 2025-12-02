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

public class RefundShippingLineEdgeQueryBuilder() : GraphQueryBuilder<RefundShippingLineEdge>("refundShippingLineEdge")
{
    public RefundShippingLineEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public RefundShippingLineEdgeQueryBuilder AddFieldNode(Func<RefundShippingLineQueryBuilder, RefundShippingLineQueryBuilder> build)
    {
        AddField<RefundShippingLine, RefundShippingLineQueryBuilder>("node", build);
        return this;
    }
}