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

public class DiscountApplicationEdgeQueryBuilder() : GraphQueryBuilder<DiscountApplicationEdge>("discountApplicationEdge")
{
    public DiscountApplicationEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DiscountApplicationEdgeQueryBuilder AddFieldNode(Func<DiscountApplicationQueryBuilder, DiscountApplicationQueryBuilder> build)
    {
        AddField<IDiscountApplication, DiscountApplicationQueryBuilder>("node", build);
        return this;
    }
}