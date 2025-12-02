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

public class PriceListEdgeQueryBuilder() : GraphQueryBuilder<PriceListEdge>("priceListEdge")
{
    public PriceListEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public PriceListEdgeQueryBuilder AddFieldNode(Func<PriceListQueryBuilder, PriceListQueryBuilder> build)
    {
        AddField<PriceList, PriceListQueryBuilder>("node", build);
        return this;
    }
}