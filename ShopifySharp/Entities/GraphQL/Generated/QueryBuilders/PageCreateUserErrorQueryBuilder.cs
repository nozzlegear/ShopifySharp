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

public class PageCreateUserErrorQueryBuilder() : GraphQueryBuilder<PageCreateUserError>("query pageCreateUserError")
{
    public PageCreateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public PageCreateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public PageCreateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}