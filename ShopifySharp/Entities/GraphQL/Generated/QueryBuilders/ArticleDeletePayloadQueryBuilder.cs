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

public class ArticleDeletePayloadQueryBuilder() : GraphQueryBuilder<ArticleDeletePayload>("query articleDeletePayload")
{
    public ArticleDeletePayloadQueryBuilder AddFieldDeletedArticleId()
    {
        AddField("deletedArticleId");
        return this;
    }

    public ArticleDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}