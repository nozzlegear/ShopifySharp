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

public class MenuCreateQueryBuilder() : GraphQueryBuilder<MenuCreatePayload>("menuCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public MenuCreateQueryBuilder AddArgumentHandle(string? handle)
    {
        AddArgument("handle", handle);
        return this;
    }

    public MenuCreateQueryBuilder AddArgumentItems(ICollection<MenuItemCreateInput>? items)
    {
        AddArgument("items", items);
        return this;
    }

    public MenuCreateQueryBuilder AddArgumentTitle(string? title)
    {
        AddArgument("title", title);
        return this;
    }
}