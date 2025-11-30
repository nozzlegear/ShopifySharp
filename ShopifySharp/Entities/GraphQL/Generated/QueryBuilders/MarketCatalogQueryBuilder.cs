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

public class MarketCatalogQueryBuilder() : GraphQueryBuilder<MarketCatalog>("query marketCatalog")
{
    public MarketCatalogQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public MarketCatalogQueryBuilder AddFieldMarkets()
    {
        AddField("markets");
        return this;
    }

    public MarketCatalogQueryBuilder AddFieldMarketsCount()
    {
        AddField("marketsCount");
        return this;
    }

    public MarketCatalogQueryBuilder AddFieldOperations()
    {
        AddField("operations");
        return this;
    }

    public MarketCatalogQueryBuilder AddFieldPriceList()
    {
        AddField("priceList");
        return this;
    }

    public MarketCatalogQueryBuilder AddFieldPublication()
    {
        AddField("publication");
        return this;
    }

    public MarketCatalogQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public MarketCatalogQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}