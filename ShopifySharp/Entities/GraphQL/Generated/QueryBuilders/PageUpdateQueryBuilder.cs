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

public class PageUpdateQueryBuilder() : GraphQueryBuilder<PageUpdatePayload>("query pageUpdate")
{
    public PageUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public PageUpdateQueryBuilder AddArgumentPage(PageUpdateInput? page)
    {
        AddArgument("page", page);
        return this;
    }
}