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

public class MenuDeleteUserErrorQueryBuilder() : GraphQueryBuilder<MenuDeleteUserError>("query menuDeleteUserError")
{
    public MenuDeleteUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MenuDeleteUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public MenuDeleteUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}