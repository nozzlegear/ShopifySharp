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

public class ThemeUpdateUserErrorQueryBuilder() : GraphQueryBuilder<ThemeUpdateUserError>("query themeUpdateUserError")
{
    public ThemeUpdateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ThemeUpdateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ThemeUpdateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}