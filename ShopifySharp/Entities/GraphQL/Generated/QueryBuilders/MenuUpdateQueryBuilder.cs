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

public class MenuUpdateQueryBuilder() : GraphQueryBuilder<MenuUpdatePayload>("query menuUpdate")
{
    public MenuUpdateQueryBuilder AddArgumentHandle(string? handle)
    {
        AddArgument("handle", handle);
        return this;
    }

    public MenuUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public MenuUpdateQueryBuilder AddArgumentItems(ICollection<MenuItemUpdateInput>? items)
    {
        AddArgument("items", items);
        return this;
    }

    public MenuUpdateQueryBuilder AddArgumentTitle(string? title)
    {
        AddArgument("title", title);
        return this;
    }
}