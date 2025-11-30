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

public class ArticleCreateQueryBuilder() : GraphQueryBuilder<ArticleCreatePayload>("query articleCreate")
{
    public ArticleCreateQueryBuilder AddArgumentArticle(ArticleCreateInput? article)
    {
        AddArgument("article", article);
        return this;
    }

    public ArticleCreateQueryBuilder AddArgumentBlog(ArticleBlogInput? blog)
    {
        AddArgument("blog", blog);
        return this;
    }
}