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

public class ThemeUpdateQueryBuilder() : GraphQueryBuilder<ThemeUpdatePayload>("query themeUpdate")
{
    public ThemeUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public ThemeUpdateQueryBuilder AddArgumentInput(OnlineStoreThemeInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}