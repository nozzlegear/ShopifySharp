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

public class ThemePublishPayloadQueryBuilder() : GraphQueryBuilder<ThemePublishPayload>("themePublishPayload")
{
    public ThemePublishPayloadQueryBuilder AddFieldTheme(Func<OnlineStoreThemeQueryBuilder, OnlineStoreThemeQueryBuilder> build)
    {
        AddField<OnlineStoreTheme, OnlineStoreThemeQueryBuilder>("theme", build);
        return this;
    }

    public ThemePublishPayloadQueryBuilder AddFieldUserErrors(Func<ThemePublishUserErrorQueryBuilder, ThemePublishUserErrorQueryBuilder> build)
    {
        AddField<ThemePublishUserError, ThemePublishUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}