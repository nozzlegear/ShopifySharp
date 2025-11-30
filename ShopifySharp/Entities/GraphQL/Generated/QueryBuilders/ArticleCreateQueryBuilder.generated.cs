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

public class ArticleCreateQueryBuilder() : GraphQueryBuilder<ArticleCreatePayload>("articleCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

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