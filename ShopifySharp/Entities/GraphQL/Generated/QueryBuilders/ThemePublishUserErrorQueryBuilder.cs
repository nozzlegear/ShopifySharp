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

public class ThemePublishUserErrorQueryBuilder() : GraphQueryBuilder<ThemePublishUserError>("query themePublishUserError")
{
    public ThemePublishUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ThemePublishUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public ThemePublishUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}