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

public class ThemeUpdatePayloadQueryBuilder() : GraphQueryBuilder<ThemeUpdatePayload>("query themeUpdatePayload")
{
    public ThemeUpdatePayloadQueryBuilder AddFieldTheme()
    {
        AddField("theme");
        return this;
    }

    public ThemeUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}