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

public class CartTransformEdgeQueryBuilder() : GraphQueryBuilder<CartTransformEdge>("query cartTransformEdge")
{
    public CartTransformEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CartTransformEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}