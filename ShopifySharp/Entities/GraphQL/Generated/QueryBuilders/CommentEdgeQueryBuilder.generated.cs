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

public class CommentEdgeQueryBuilder() : GraphQueryBuilder<CommentEdge>("commentEdge")
{
    public CommentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CommentEdgeQueryBuilder AddFieldNode(Func<CommentQueryBuilder, CommentQueryBuilder> build)
    {
        AddField<Comment, CommentQueryBuilder>("node", build);
        return this;
    }
}