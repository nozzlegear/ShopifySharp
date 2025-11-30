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

public class RefundLineItemEdgeQueryBuilder() : GraphQueryBuilder<RefundLineItemEdge>("refundLineItemEdge")
{
    public RefundLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public RefundLineItemEdgeQueryBuilder AddFieldNode(Func<RefundLineItemQueryBuilder, RefundLineItemQueryBuilder> build)
    {
        AddField<RefundLineItem, RefundLineItemQueryBuilder>("node", build);
        return this;
    }
}