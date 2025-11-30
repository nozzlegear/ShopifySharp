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

public class BlogConnectionQueryBuilder() : GraphQueryBuilder<BlogConnection>("blogConnection")
{
    public BlogConnectionQueryBuilder AddFieldEdges(Func<BlogEdgeQueryBuilder, BlogEdgeQueryBuilder> build)
    {
        AddField<BlogEdge, BlogEdgeQueryBuilder>("edges", build);
        return this;
    }

    public BlogConnectionQueryBuilder AddFieldNodes(Func<BlogQueryBuilder, BlogQueryBuilder> build)
    {
        AddField<Blog, BlogQueryBuilder>("nodes", build);
        return this;
    }

    public BlogConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}