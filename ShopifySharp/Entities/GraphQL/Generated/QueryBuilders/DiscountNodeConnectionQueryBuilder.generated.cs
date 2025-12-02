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

public class DiscountNodeConnectionQueryBuilder() : GraphQueryBuilder<DiscountNodeConnection>("discountNodeConnection")
{
    public DiscountNodeConnectionQueryBuilder AddFieldEdges(Func<DiscountNodeEdgeQueryBuilder, DiscountNodeEdgeQueryBuilder> build)
    {
        AddField<DiscountNodeEdge, DiscountNodeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DiscountNodeConnectionQueryBuilder AddFieldNodes(Func<DiscountNodeQueryBuilder, DiscountNodeQueryBuilder> build)
    {
        AddField<DiscountNode, DiscountNodeQueryBuilder>("nodes", build);
        return this;
    }

    public DiscountNodeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}