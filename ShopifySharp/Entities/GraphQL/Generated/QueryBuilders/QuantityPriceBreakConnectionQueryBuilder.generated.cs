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

public class QuantityPriceBreakConnectionQueryBuilder() : GraphQueryBuilder<QuantityPriceBreakConnection>("quantityPriceBreakConnection")
{
    public QuantityPriceBreakConnectionQueryBuilder AddFieldEdges(Func<QuantityPriceBreakEdgeQueryBuilder, QuantityPriceBreakEdgeQueryBuilder> build)
    {
        AddField<QuantityPriceBreakEdge, QuantityPriceBreakEdgeQueryBuilder>("edges", build);
        return this;
    }

    public QuantityPriceBreakConnectionQueryBuilder AddFieldNodes(Func<QuantityPriceBreakQueryBuilder, QuantityPriceBreakQueryBuilder> build)
    {
        AddField<QuantityPriceBreak, QuantityPriceBreakQueryBuilder>("nodes", build);
        return this;
    }

    public QuantityPriceBreakConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}