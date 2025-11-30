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

public class TranslationQueryBuilder() : GraphQueryBuilder<Translation>("translation")
{
    public TranslationQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public TranslationQueryBuilder AddFieldLocale()
    {
        AddField("locale");
        return this;
    }

    public TranslationQueryBuilder AddFieldMarket(Func<MarketQueryBuilder, MarketQueryBuilder> build)
    {
        AddField<Market, MarketQueryBuilder>("market", build);
        return this;
    }

    public TranslationQueryBuilder AddFieldOutdated()
    {
        AddField("outdated");
        return this;
    }

    public TranslationQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    public TranslationQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}