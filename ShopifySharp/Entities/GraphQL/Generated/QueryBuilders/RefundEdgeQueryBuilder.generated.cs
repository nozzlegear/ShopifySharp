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

public class RefundEdgeQueryBuilder() : GraphQueryBuilder<RefundEdge>("refundEdge")
{
    public RefundEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public RefundEdgeQueryBuilder AddFieldNode(Func<RefundQueryBuilder, RefundQueryBuilder> build)
    {
        AddField<Refund, RefundQueryBuilder>("node", build);
        return this;
    }
}