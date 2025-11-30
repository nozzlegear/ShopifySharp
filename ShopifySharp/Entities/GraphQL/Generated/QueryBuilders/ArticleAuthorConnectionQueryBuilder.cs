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

public class ArticleAuthorConnectionQueryBuilder() : GraphQueryBuilder<ArticleAuthorConnection>("query articleAuthorConnection")
{
    public ArticleAuthorConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ArticleAuthorConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ArticleAuthorConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}