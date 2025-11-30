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

public class ThemeCreatePayloadQueryBuilder() : GraphQueryBuilder<ThemeCreatePayload>("themeCreatePayload")
{
    public ThemeCreatePayloadQueryBuilder AddFieldTheme(Func<OnlineStoreThemeQueryBuilder, OnlineStoreThemeQueryBuilder> build)
    {
        AddField<OnlineStoreTheme, OnlineStoreThemeQueryBuilder>("theme", build);
        return this;
    }

    public ThemeCreatePayloadQueryBuilder AddFieldUserErrors(Func<ThemeCreateUserErrorQueryBuilder, ThemeCreateUserErrorQueryBuilder> build)
    {
        AddField<ThemeCreateUserError, ThemeCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}