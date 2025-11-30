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

public class DiscountAutomaticEdgeQueryBuilder() : GraphQueryBuilder<DiscountAutomaticEdge>("discountAutomaticEdge")
{
    public DiscountAutomaticEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DiscountAutomaticEdgeQueryBuilder AddUnionCaseNode(Func<DiscountAutomaticAppQueryBuilder, DiscountAutomaticAppQueryBuilder> build)
    {
        AddUnion<DiscountAutomaticApp, DiscountAutomaticAppQueryBuilder>("node", build);
        return this;
    }

    public DiscountAutomaticEdgeQueryBuilder AddUnionCaseNode(Func<DiscountAutomaticBasicQueryBuilder, DiscountAutomaticBasicQueryBuilder> build)
    {
        AddUnion<DiscountAutomaticBasic, DiscountAutomaticBasicQueryBuilder>("node", build);
        return this;
    }

    public DiscountAutomaticEdgeQueryBuilder AddUnionCaseNode(Func<DiscountAutomaticBxgyQueryBuilder, DiscountAutomaticBxgyQueryBuilder> build)
    {
        AddUnion<DiscountAutomaticBxgy, DiscountAutomaticBxgyQueryBuilder>("node", build);
        return this;
    }

    public DiscountAutomaticEdgeQueryBuilder AddUnionCaseNode(Func<DiscountAutomaticFreeShippingQueryBuilder, DiscountAutomaticFreeShippingQueryBuilder> build)
    {
        AddUnion<DiscountAutomaticFreeShipping, DiscountAutomaticFreeShippingQueryBuilder>("node", build);
        return this;
    }
}