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

public class TaxLineQueryBuilder() : GraphQueryBuilder<TaxLine>("taxLine")
{
    public TaxLineQueryBuilder AddFieldChannelLiable()
    {
        AddField("channelLiable");
        return this;
    }

    [Obsolete("Use `priceSet` instead.")]
    public TaxLineQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public TaxLineQueryBuilder AddFieldPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("priceSet", build);
        return this;
    }

    public TaxLineQueryBuilder AddFieldRate()
    {
        AddField("rate");
        return this;
    }

    public TaxLineQueryBuilder AddFieldRatePercentage()
    {
        AddField("ratePercentage");
        return this;
    }

    public TaxLineQueryBuilder AddFieldSource()
    {
        AddField("source");
        return this;
    }

    public TaxLineQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}