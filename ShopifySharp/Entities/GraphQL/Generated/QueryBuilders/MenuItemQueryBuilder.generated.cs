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

public class MenuItemQueryBuilder() : GraphQueryBuilder<MenuItem>("menuItem")
{
    public MenuItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public MenuItemQueryBuilder AddFieldItems(Func<MenuItemQueryBuilder, MenuItemQueryBuilder> build)
    {
        AddField<MenuItem, MenuItemQueryBuilder>("items", build);
        return this;
    }

    public MenuItemQueryBuilder AddFieldResourceId()
    {
        AddField("resourceId");
        return this;
    }

    public MenuItemQueryBuilder AddFieldTags()
    {
        AddField("tags");
        return this;
    }

    public MenuItemQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public MenuItemQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public MenuItemQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}