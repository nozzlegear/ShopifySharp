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

public class ArticleUpdateUserErrorQueryBuilder() : GraphQueryBuilder<ArticleUpdateUserError>("query articleUpdateUserError")
{
    public ArticleUpdateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ArticleUpdateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ArticleUpdateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}