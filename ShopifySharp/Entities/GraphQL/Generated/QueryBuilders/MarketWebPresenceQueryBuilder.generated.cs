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

public class MarketWebPresenceQueryBuilder() : GraphQueryBuilder<MarketWebPresence>("marketWebPresence")
{
    public MarketWebPresenceQueryBuilder AddFieldAlternateLocales(Func<ShopLocaleQueryBuilder, ShopLocaleQueryBuilder> build)
    {
        AddField<ShopLocale, ShopLocaleQueryBuilder>("alternateLocales", build);
        return this;
    }

    public MarketWebPresenceQueryBuilder AddFieldDefaultLocale(Func<ShopLocaleQueryBuilder, ShopLocaleQueryBuilder> build)
    {
        AddField<ShopLocale, ShopLocaleQueryBuilder>("defaultLocale", build);
        return this;
    }

    public MarketWebPresenceQueryBuilder AddFieldDomain(Func<DomainQueryBuilder, DomainQueryBuilder> build)
    {
        AddField<Domain, DomainQueryBuilder>("domain", build);
        return this;
    }

    public MarketWebPresenceQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public MarketWebPresenceQueryBuilder AddFieldMarket(Func<MarketQueryBuilder, MarketQueryBuilder> build)
    {
        AddField<Market, MarketQueryBuilder>("market", build);
        return this;
    }

    public MarketWebPresenceQueryBuilder AddFieldMarkets(Func<MarketConnectionQueryBuilder, MarketConnectionQueryBuilder> build)
    {
        AddField<MarketConnection, MarketConnectionQueryBuilder>("markets", build);
        return this;
    }

    public MarketWebPresenceQueryBuilder AddFieldRootUrls(Func<MarketWebPresenceRootUrlQueryBuilder, MarketWebPresenceRootUrlQueryBuilder> build)
    {
        AddField<MarketWebPresenceRootUrl, MarketWebPresenceRootUrlQueryBuilder>("rootUrls", build);
        return this;
    }

    public MarketWebPresenceQueryBuilder AddFieldSubfolderSuffix()
    {
        AddField("subfolderSuffix");
        return this;
    }
}