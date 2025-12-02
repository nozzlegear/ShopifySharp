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

public class CalculatedDiscountApplicationConnectionQueryBuilder() : GraphQueryBuilder<CalculatedDiscountApplicationConnection>("calculatedDiscountApplicationConnection")
{
    public CalculatedDiscountApplicationConnectionQueryBuilder AddFieldEdges(Func<CalculatedDiscountApplicationEdgeQueryBuilder, CalculatedDiscountApplicationEdgeQueryBuilder> build)
    {
        AddField<CalculatedDiscountApplicationEdge, CalculatedDiscountApplicationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CalculatedDiscountApplicationConnectionQueryBuilder AddFieldNodes(Func<CalculatedDiscountApplicationQueryBuilder, CalculatedDiscountApplicationQueryBuilder> build)
    {
        AddField<ICalculatedDiscountApplication, CalculatedDiscountApplicationQueryBuilder>("nodes", build);
        return this;
    }

    public CalculatedDiscountApplicationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}