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

public class MarketCatalogQueryBuilder() : GraphQueryBuilder<MarketCatalog>("marketCatalog")
{
    public MarketCatalogQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public MarketCatalogQueryBuilder AddFieldMarkets(Func<MarketConnectionQueryBuilder, MarketConnectionQueryBuilder> build)
    {
        AddField<MarketConnection, MarketConnectionQueryBuilder>("markets", build);
        return this;
    }

    public MarketCatalogQueryBuilder AddFieldMarketsCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("marketsCount", build);
        return this;
    }

    public MarketCatalogQueryBuilder AddFieldOperations(Func<ResourceOperationQueryBuilder, ResourceOperationQueryBuilder> build)
    {
        AddField<IResourceOperation, ResourceOperationQueryBuilder>("operations", build);
        return this;
    }

    public MarketCatalogQueryBuilder AddFieldPriceList(Func<PriceListQueryBuilder, PriceListQueryBuilder> build)
    {
        AddField<PriceList, PriceListQueryBuilder>("priceList", build);
        return this;
    }

    public MarketCatalogQueryBuilder AddFieldPublication(Func<PublicationQueryBuilder, PublicationQueryBuilder> build)
    {
        AddField<Publication, PublicationQueryBuilder>("publication", build);
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