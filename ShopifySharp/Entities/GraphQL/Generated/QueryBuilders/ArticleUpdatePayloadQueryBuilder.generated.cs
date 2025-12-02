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

public class ArticleUpdatePayloadQueryBuilder() : GraphQueryBuilder<ArticleUpdatePayload>("articleUpdatePayload")
{
    public ArticleUpdatePayloadQueryBuilder AddFieldArticle(Func<ArticleQueryBuilder, ArticleQueryBuilder> build)
    {
        AddField<Article, ArticleQueryBuilder>("article", build);
        return this;
    }

    public ArticleUpdatePayloadQueryBuilder AddFieldUserErrors(Func<ArticleUpdateUserErrorQueryBuilder, ArticleUpdateUserErrorQueryBuilder> build)
    {
        AddField<ArticleUpdateUserError, ArticleUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}