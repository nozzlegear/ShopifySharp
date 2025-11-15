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

public class ThemePublishPayloadQueryBuilder() : GraphQueryBuilder<ThemePublishPayload>("query themePublishPayload")
{
    public ThemePublishPayloadQueryBuilder AddFieldTheme()
    {
        AddField("theme");
        return this;
    }

    public ThemePublishPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}