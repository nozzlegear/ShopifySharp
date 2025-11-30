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

public class MenuCreateUserErrorQueryBuilder() : GraphQueryBuilder<MenuCreateUserError>("query menuCreateUserError")
{
    public MenuCreateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MenuCreateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public MenuCreateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}