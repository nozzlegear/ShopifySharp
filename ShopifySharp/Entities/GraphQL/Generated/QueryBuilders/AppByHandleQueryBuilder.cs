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

public class AppByHandleQueryBuilder() : GraphQueryBuilder<App>("query appByHandle")
{
    public AppByHandleQueryBuilder AddArgumentHandle(string? handle)
    {
        AddArgument("handle", handle);
        return this;
    }
}