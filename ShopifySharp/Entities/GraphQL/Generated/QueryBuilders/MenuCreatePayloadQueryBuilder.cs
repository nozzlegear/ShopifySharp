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

public class MenuCreatePayloadQueryBuilder() : GraphQueryBuilder<MenuCreatePayload>("query menuCreatePayload")
{
    public MenuCreatePayloadQueryBuilder AddFieldMenu()
    {
        AddField("menu");
        return this;
    }

    public MenuCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}