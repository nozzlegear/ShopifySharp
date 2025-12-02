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

public class DiscountAutomaticFreeShippingCreatePayloadQueryBuilder() : GraphQueryBuilder<DiscountAutomaticFreeShippingCreatePayload>("discountAutomaticFreeShippingCreatePayload")
{
    public DiscountAutomaticFreeShippingCreatePayloadQueryBuilder AddFieldAutomaticDiscountNode(Func<DiscountAutomaticNodeQueryBuilder, DiscountAutomaticNodeQueryBuilder> build)
    {
        AddField<DiscountAutomaticNode, DiscountAutomaticNodeQueryBuilder>("automaticDiscountNode", build);
        return this;
    }

    public DiscountAutomaticFreeShippingCreatePayloadQueryBuilder AddFieldUserErrors(Func<DiscountUserErrorQueryBuilder, DiscountUserErrorQueryBuilder> build)
    {
        AddField<DiscountUserError, DiscountUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}