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

public class ThemeFilesUpsertPayloadQueryBuilder() : GraphQueryBuilder<ThemeFilesUpsertPayload>("query themeFilesUpsertPayload")
{
    public ThemeFilesUpsertPayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public ThemeFilesUpsertPayloadQueryBuilder AddFieldUpsertedThemeFiles()
    {
        AddField("upsertedThemeFiles");
        return this;
    }

    public ThemeFilesUpsertPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}