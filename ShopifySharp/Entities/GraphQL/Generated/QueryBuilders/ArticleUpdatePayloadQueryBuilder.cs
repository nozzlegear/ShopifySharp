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

public class ArticleUpdatePayloadQueryBuilder() : GraphQueryBuilder<ArticleUpdatePayload>("query articleUpdatePayload")
{
    public ArticleUpdatePayloadQueryBuilder AddFieldArticle()
    {
        AddField("article");
        return this;
    }

    public ArticleUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}