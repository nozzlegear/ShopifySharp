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

public class LineItemEdgeQueryBuilder() : GraphQueryBuilder<LineItemEdge>("query lineItemEdge")
{
    public LineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public LineItemEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}