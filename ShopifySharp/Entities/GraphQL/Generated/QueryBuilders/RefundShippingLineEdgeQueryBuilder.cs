#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class RefundShippingLineEdgeQueryBuilder() : GraphQueryBuilder<RefundShippingLineEdge>("query refundShippingLineEdge")
{
    public RefundShippingLineEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public RefundShippingLineEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}