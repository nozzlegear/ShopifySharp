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

public class ArticleUpdateQueryBuilder() : GraphQueryBuilder<ArticleUpdatePayload>("query articleUpdate")
{
    public ArticleUpdateQueryBuilder AddArgumentArticle(ArticleUpdateInput? article)
    {
        AddArgument("article", article);
        return this;
    }

    public ArticleUpdateQueryBuilder AddArgumentBlog(ArticleBlogInput? blog)
    {
        AddArgument("blog", blog);
        return this;
    }

    public ArticleUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}