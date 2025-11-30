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

public class ArticleAuthorConnectionQueryBuilder() : GraphQueryBuilder<ArticleAuthorConnection>("articleAuthorConnection")
{
    public ArticleAuthorConnectionQueryBuilder AddFieldEdges(Func<ArticleAuthorEdgeQueryBuilder, ArticleAuthorEdgeQueryBuilder> build)
    {
        AddField<ArticleAuthorEdge, ArticleAuthorEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ArticleAuthorConnectionQueryBuilder AddFieldNodes(Func<ArticleAuthorQueryBuilder, ArticleAuthorQueryBuilder> build)
    {
        AddField<ArticleAuthor, ArticleAuthorQueryBuilder>("nodes", build);
        return this;
    }

    public ArticleAuthorConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}