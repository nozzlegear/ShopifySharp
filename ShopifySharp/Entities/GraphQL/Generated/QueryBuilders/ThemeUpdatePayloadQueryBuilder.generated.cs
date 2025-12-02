#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ThemeUpdatePayloadQueryBuilder() : GraphQueryBuilder<ThemeUpdatePayload>("themeUpdatePayload")
{
    public ThemeUpdatePayloadQueryBuilder AddFieldTheme(Func<OnlineStoreThemeQueryBuilder, OnlineStoreThemeQueryBuilder> build)
    {
        AddField<OnlineStoreTheme, OnlineStoreThemeQueryBuilder>("theme", build);
        return this;
    }

    public ThemeUpdatePayloadQueryBuilder AddFieldUserErrors(Func<ThemeUpdateUserErrorQueryBuilder, ThemeUpdateUserErrorQueryBuilder> build)
    {
        AddField<ThemeUpdateUserError, ThemeUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}