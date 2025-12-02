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

public class ArticleCreatePayloadQueryBuilder() : GraphQueryBuilder<ArticleCreatePayload>("articleCreatePayload")
{
    public ArticleCreatePayloadQueryBuilder AddFieldArticle(Func<ArticleQueryBuilder, ArticleQueryBuilder> build)
    {
        AddField<Article, ArticleQueryBuilder>("article", build);
        return this;
    }

    public ArticleCreatePayloadQueryBuilder AddFieldUserErrors(Func<ArticleCreateUserErrorQueryBuilder, ArticleCreateUserErrorQueryBuilder> build)
    {
        AddField<ArticleCreateUserError, ArticleCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}