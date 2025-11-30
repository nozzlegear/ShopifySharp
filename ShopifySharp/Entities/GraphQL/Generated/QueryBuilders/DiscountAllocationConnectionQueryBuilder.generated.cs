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

public class DiscountAllocationConnectionQueryBuilder() : GraphQueryBuilder<DiscountAllocationConnection>("discountAllocationConnection")
{
    public DiscountAllocationConnectionQueryBuilder AddFieldEdges(Func<DiscountAllocationEdgeQueryBuilder, DiscountAllocationEdgeQueryBuilder> build)
    {
        AddField<DiscountAllocationEdge, DiscountAllocationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DiscountAllocationConnectionQueryBuilder AddFieldNodes(Func<DiscountAllocationQueryBuilder, DiscountAllocationQueryBuilder> build)
    {
        AddField<DiscountAllocation, DiscountAllocationQueryBuilder>("nodes", build);
        return this;
    }

    public DiscountAllocationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}