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

public class ArticleConnectionQueryBuilder() : GraphQueryBuilder<ArticleConnection>("articleConnection")
{
    public ArticleConnectionQueryBuilder AddFieldEdges(Func<ArticleEdgeQueryBuilder, ArticleEdgeQueryBuilder> build)
    {
        AddField<ArticleEdge, ArticleEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ArticleConnectionQueryBuilder AddFieldNodes(Func<ArticleQueryBuilder, ArticleQueryBuilder> build)
    {
        AddField<Article, ArticleQueryBuilder>("nodes", build);
        return this;
    }

    public ArticleConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}