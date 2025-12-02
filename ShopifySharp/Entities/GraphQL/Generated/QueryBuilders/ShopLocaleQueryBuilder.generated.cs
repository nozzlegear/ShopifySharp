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

public class ShopLocaleQueryBuilder() : GraphQueryBuilder<ShopLocale>("shopLocale")
{
    public ShopLocaleQueryBuilder AddFieldLocale()
    {
        AddField("locale");
        return this;
    }

    public ShopLocaleQueryBuilder AddFieldMarketWebPresences(Func<MarketWebPresenceQueryBuilder, MarketWebPresenceQueryBuilder> build)
    {
        AddField<MarketWebPresence, MarketWebPresenceQueryBuilder>("marketWebPresences", build);
        return this;
    }

    public ShopLocaleQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ShopLocaleQueryBuilder AddFieldPrimary()
    {
        AddField("primary");
        return this;
    }

    public ShopLocaleQueryBuilder AddFieldPublished()
    {
        AddField("published");
        return this;
    }
}