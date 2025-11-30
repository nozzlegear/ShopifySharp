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

public class ThemeCreatePayloadQueryBuilder() : GraphQueryBuilder<ThemeCreatePayload>("query themeCreatePayload")
{
    public ThemeCreatePayloadQueryBuilder AddFieldTheme()
    {
        AddField("theme");
        return this;
    }

    public ThemeCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}