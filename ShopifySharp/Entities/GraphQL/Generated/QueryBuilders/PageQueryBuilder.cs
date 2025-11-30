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

public class PageQueryBuilder() : GraphQueryBuilder<Page>("query page")
{
    public PageQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}