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

public class PriceListConnectionQueryBuilder() : GraphQueryBuilder<PriceListConnection>("priceListConnection")
{
    public PriceListConnectionQueryBuilder AddFieldEdges(Func<PriceListEdgeQueryBuilder, PriceListEdgeQueryBuilder> build)
    {
        AddField<PriceListEdge, PriceListEdgeQueryBuilder>("edges", build);
        return this;
    }

    public PriceListConnectionQueryBuilder AddFieldNodes(Func<PriceListQueryBuilder, PriceListQueryBuilder> build)
    {
        AddField<PriceList, PriceListQueryBuilder>("nodes", build);
        return this;
    }

    public PriceListConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}