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

public class PriceListPriceConnectionQueryBuilder() : GraphQueryBuilder<PriceListPriceConnection>("priceListPriceConnection")
{
    public PriceListPriceConnectionQueryBuilder AddFieldEdges(Func<PriceListPriceEdgeQueryBuilder, PriceListPriceEdgeQueryBuilder> build)
    {
        AddField<PriceListPriceEdge, PriceListPriceEdgeQueryBuilder>("edges", build);
        return this;
    }

    public PriceListPriceConnectionQueryBuilder AddFieldNodes(Func<PriceListPriceQueryBuilder, PriceListPriceQueryBuilder> build)
    {
        AddField<PriceListPrice, PriceListPriceQueryBuilder>("nodes", build);
        return this;
    }

    public PriceListPriceConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}