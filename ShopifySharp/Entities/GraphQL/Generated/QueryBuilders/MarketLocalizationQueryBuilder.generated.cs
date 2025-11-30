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

public class MarketLocalizationQueryBuilder() : GraphQueryBuilder<MarketLocalization>("marketLocalization")
{
    public MarketLocalizationQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public MarketLocalizationQueryBuilder AddFieldMarket(Func<MarketQueryBuilder, MarketQueryBuilder> build)
    {
        AddField<Market, MarketQueryBuilder>("market", build);
        return this;
    }

    public MarketLocalizationQueryBuilder AddFieldOutdated()
    {
        AddField("outdated");
        return this;
    }

    public MarketLocalizationQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    public MarketLocalizationQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}