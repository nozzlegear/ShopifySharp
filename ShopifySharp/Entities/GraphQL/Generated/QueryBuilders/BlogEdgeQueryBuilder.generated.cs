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

public class BlogEdgeQueryBuilder() : GraphQueryBuilder<BlogEdge>("blogEdge")
{
    public BlogEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public BlogEdgeQueryBuilder AddFieldNode(Func<BlogQueryBuilder, BlogQueryBuilder> build)
    {
        AddField<Blog, BlogQueryBuilder>("node", build);
        return this;
    }
}