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

public class DiscountApplicationConnectionQueryBuilder() : GraphQueryBuilder<DiscountApplicationConnection>("discountApplicationConnection")
{
    public DiscountApplicationConnectionQueryBuilder AddFieldEdges(Func<DiscountApplicationEdgeQueryBuilder, DiscountApplicationEdgeQueryBuilder> build)
    {
        AddField<DiscountApplicationEdge, DiscountApplicationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DiscountApplicationConnectionQueryBuilder AddFieldNodes(Func<DiscountApplicationQueryBuilder, DiscountApplicationQueryBuilder> build)
    {
        AddField<IDiscountApplication, DiscountApplicationQueryBuilder>("nodes", build);
        return this;
    }

    public DiscountApplicationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}