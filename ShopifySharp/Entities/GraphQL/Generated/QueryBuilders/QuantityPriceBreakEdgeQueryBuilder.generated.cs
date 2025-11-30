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

public class QuantityPriceBreakEdgeQueryBuilder() : GraphQueryBuilder<QuantityPriceBreakEdge>("quantityPriceBreakEdge")
{
    public QuantityPriceBreakEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public QuantityPriceBreakEdgeQueryBuilder AddFieldNode(Func<QuantityPriceBreakQueryBuilder, QuantityPriceBreakQueryBuilder> build)
    {
        AddField<QuantityPriceBreak, QuantityPriceBreakQueryBuilder>("node", build);
        return this;
    }
}