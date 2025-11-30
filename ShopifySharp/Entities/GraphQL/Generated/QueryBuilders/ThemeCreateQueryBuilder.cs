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

public class ThemeCreateQueryBuilder() : GraphQueryBuilder<ThemeCreatePayload>("query themeCreate")
{
    public ThemeCreateQueryBuilder AddArgumentName(string? name)
    {
        AddArgument("name", name);
        return this;
    }

    public ThemeCreateQueryBuilder AddArgumentRole(ThemeRole? role)
    {
        AddArgument("role", role);
        return this;
    }

    public ThemeCreateQueryBuilder AddArgumentSource(string? source)
    {
        AddArgument("source", source);
        return this;
    }
}