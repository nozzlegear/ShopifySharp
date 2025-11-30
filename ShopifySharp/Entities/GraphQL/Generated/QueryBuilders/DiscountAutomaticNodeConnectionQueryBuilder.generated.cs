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

public class DiscountAutomaticNodeConnectionQueryBuilder() : GraphQueryBuilder<DiscountAutomaticNodeConnection>("discountAutomaticNodeConnection")
{
    public DiscountAutomaticNodeConnectionQueryBuilder AddFieldEdges(Func<DiscountAutomaticNodeEdgeQueryBuilder, DiscountAutomaticNodeEdgeQueryBuilder> build)
    {
        AddField<DiscountAutomaticNodeEdge, DiscountAutomaticNodeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DiscountAutomaticNodeConnectionQueryBuilder AddFieldNodes(Func<DiscountAutomaticNodeQueryBuilder, DiscountAutomaticNodeQueryBuilder> build)
    {
        AddField<DiscountAutomaticNode, DiscountAutomaticNodeQueryBuilder>("nodes", build);
        return this;
    }

    public DiscountAutomaticNodeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}