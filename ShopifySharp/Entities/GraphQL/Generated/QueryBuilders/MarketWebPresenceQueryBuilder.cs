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

public class MarketWebPresenceQueryBuilder() : GraphQueryBuilder<MarketWebPresence>("query marketWebPresence")
{
    public MarketWebPresenceQueryBuilder AddFieldAlternateLocales()
    {
        AddField("alternateLocales");
        return this;
    }

    public MarketWebPresenceQueryBuilder AddFieldDefaultLocale()
    {
        AddField("defaultLocale");
        return this;
    }

    public MarketWebPresenceQueryBuilder AddFieldDomain()
    {
        AddField("domain");
        return this;
    }

    public MarketWebPresenceQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    [Obsolete("Use `markets` instead.")]
    public MarketWebPresenceQueryBuilder AddFieldMarket()
    {
        AddField("market");
        return this;
    }

    public MarketWebPresenceQueryBuilder AddFieldMarkets()
    {
        AddField("markets");
        return this;
    }

    public MarketWebPresenceQueryBuilder AddFieldRootUrls()
    {
        AddField("rootUrls");
        return this;
    }

    public MarketWebPresenceQueryBuilder AddFieldSubfolderSuffix()
    {
        AddField("subfolderSuffix");
        return this;
    }
}