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

public class ThemeFilesDeletePayloadQueryBuilder() : GraphQueryBuilder<ThemeFilesDeletePayload>("query themeFilesDeletePayload")
{
    public ThemeFilesDeletePayloadQueryBuilder AddFieldDeletedThemeFiles()
    {
        AddField("deletedThemeFiles");
        return this;
    }

    public ThemeFilesDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}