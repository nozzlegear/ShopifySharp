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

public class MenuDeletePayloadQueryBuilder() : GraphQueryBuilder<MenuDeletePayload>("menuDeletePayload")
{
    public MenuDeletePayloadQueryBuilder AddFieldDeletedMenuId()
    {
        AddField("deletedMenuId");
        return this;
    }

    public MenuDeletePayloadQueryBuilder AddFieldUserErrors(Func<MenuDeleteUserErrorQueryBuilder, MenuDeleteUserErrorQueryBuilder> build)
    {
        AddField<MenuDeleteUserError, MenuDeleteUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}