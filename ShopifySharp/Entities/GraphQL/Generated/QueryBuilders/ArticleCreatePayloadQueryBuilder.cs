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

public class ArticleCreatePayloadQueryBuilder() : GraphQueryBuilder<ArticleCreatePayload>("query articleCreatePayload")
{
    public ArticleCreatePayloadQueryBuilder AddFieldArticle()
    {
        AddField("article");
        return this;
    }

    public ArticleCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}