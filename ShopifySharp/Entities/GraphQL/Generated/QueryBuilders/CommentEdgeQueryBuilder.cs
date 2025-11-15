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

public class CommentEdgeQueryBuilder() : GraphQueryBuilder<CommentEdge>("query commentEdge")
{
    public CommentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CommentEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}