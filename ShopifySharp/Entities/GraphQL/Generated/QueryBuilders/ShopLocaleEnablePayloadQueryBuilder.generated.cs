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

public class ShopLocaleEnablePayloadQueryBuilder() : GraphQueryBuilder<ShopLocaleEnablePayload>("shopLocaleEnablePayload")
{
    public ShopLocaleEnablePayloadQueryBuilder AddFieldShopLocale(Func<ShopLocaleQueryBuilder, ShopLocaleQueryBuilder> build)
    {
        AddField<ShopLocale, ShopLocaleQueryBuilder>("shopLocale", build);
        return this;
    }

    public ShopLocaleEnablePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}