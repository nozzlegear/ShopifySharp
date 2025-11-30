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

public class ThemeFilesCopyPayloadQueryBuilder() : GraphQueryBuilder<ThemeFilesCopyPayload>("query themeFilesCopyPayload")
{
    public ThemeFilesCopyPayloadQueryBuilder AddFieldCopiedThemeFiles()
    {
        AddField("copiedThemeFiles");
        return this;
    }

    public ThemeFilesCopyPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}