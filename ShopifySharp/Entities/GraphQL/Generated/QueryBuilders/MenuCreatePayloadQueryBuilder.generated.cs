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

public class MenuCreatePayloadQueryBuilder() : GraphQueryBuilder<MenuCreatePayload>("menuCreatePayload")
{
    public MenuCreatePayloadQueryBuilder AddFieldMenu(Func<MenuQueryBuilder, MenuQueryBuilder> build)
    {
        AddField<Menu, MenuQueryBuilder>("menu", build);
        return this;
    }

    public MenuCreatePayloadQueryBuilder AddFieldUserErrors(Func<MenuCreateUserErrorQueryBuilder, MenuCreateUserErrorQueryBuilder> build)
    {
        AddField<MenuCreateUserError, MenuCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}