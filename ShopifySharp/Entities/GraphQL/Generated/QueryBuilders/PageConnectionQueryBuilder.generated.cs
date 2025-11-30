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

public class PageConnectionQueryBuilder() : GraphQueryBuilder<PageConnection>("pageConnection")
{
    public PageConnectionQueryBuilder AddFieldEdges(Func<PageEdgeQueryBuilder, PageEdgeQueryBuilder> build)
    {
        AddField<PageEdge, PageEdgeQueryBuilder>("edges", build);
        return this;
    }

    public PageConnectionQueryBuilder AddFieldNodes(Func<PageQueryBuilder, PageQueryBuilder> build)
    {
        AddField<Page, PageQueryBuilder>("nodes", build);
        return this;
    }

    public PageConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}