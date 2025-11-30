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

public class DiscountAutomaticConnectionQueryBuilder() : GraphQueryBuilder<DiscountAutomaticConnection>("discountAutomaticConnection")
{
    public DiscountAutomaticConnectionQueryBuilder AddFieldEdges(Func<DiscountAutomaticEdgeQueryBuilder, DiscountAutomaticEdgeQueryBuilder> build)
    {
        AddField<DiscountAutomaticEdge, DiscountAutomaticEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DiscountAutomaticConnectionQueryBuilder AddUnionCaseNodes(Func<DiscountAutomaticAppQueryBuilder, DiscountAutomaticAppQueryBuilder> build)
    {
        AddUnion<DiscountAutomaticApp, DiscountAutomaticAppQueryBuilder>("nodes", build);
        return this;
    }

    public DiscountAutomaticConnectionQueryBuilder AddUnionCaseNodes(Func<DiscountAutomaticBasicQueryBuilder, DiscountAutomaticBasicQueryBuilder> build)
    {
        AddUnion<DiscountAutomaticBasic, DiscountAutomaticBasicQueryBuilder>("nodes", build);
        return this;
    }

    public DiscountAutomaticConnectionQueryBuilder AddUnionCaseNodes(Func<DiscountAutomaticBxgyQueryBuilder, DiscountAutomaticBxgyQueryBuilder> build)
    {
        AddUnion<DiscountAutomaticBxgy, DiscountAutomaticBxgyQueryBuilder>("nodes", build);
        return this;
    }

    public DiscountAutomaticConnectionQueryBuilder AddUnionCaseNodes(Func<DiscountAutomaticFreeShippingQueryBuilder, DiscountAutomaticFreeShippingQueryBuilder> build)
    {
        AddUnion<DiscountAutomaticFreeShipping, DiscountAutomaticFreeShippingQueryBuilder>("nodes", build);
        return this;
    }

    public DiscountAutomaticConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}