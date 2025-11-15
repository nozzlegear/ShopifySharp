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

public class ShopLocaleUpdateQueryBuilder() : GraphQueryBuilder<ShopLocaleUpdatePayload>("query shopLocaleUpdate")
{
    public ShopLocaleUpdateQueryBuilder AddArgumentLocale(string? locale)
    {
        AddArgument("locale", locale);
        return this;
    }

    public ShopLocaleUpdateQueryBuilder AddArgumentShopLocale(ShopLocaleInput? shopLocale)
    {
        AddArgument("shopLocale", shopLocale);
        return this;
    }
}