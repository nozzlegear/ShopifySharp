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

public class OrderAdjustmentEdgeQueryBuilder() : GraphQueryBuilder<OrderAdjustmentEdge>("query orderAdjustmentEdge")
{
    public OrderAdjustmentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public OrderAdjustmentEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}