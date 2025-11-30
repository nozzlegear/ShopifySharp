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

public class CommentConnectionQueryBuilder() : GraphQueryBuilder<CommentConnection>("commentConnection")
{
    public CommentConnectionQueryBuilder AddFieldEdges(Func<CommentEdgeQueryBuilder, CommentEdgeQueryBuilder> build)
    {
        AddField<CommentEdge, CommentEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CommentConnectionQueryBuilder AddFieldNodes(Func<CommentQueryBuilder, CommentQueryBuilder> build)
    {
        AddField<Comment, CommentQueryBuilder>("nodes", build);
        return this;
    }

    public CommentConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}