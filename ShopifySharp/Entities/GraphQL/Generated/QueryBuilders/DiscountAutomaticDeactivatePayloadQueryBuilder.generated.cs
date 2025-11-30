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

public class DiscountAutomaticDeactivatePayloadQueryBuilder() : GraphQueryBuilder<DiscountAutomaticDeactivatePayload>("discountAutomaticDeactivatePayload")
{
    public DiscountAutomaticDeactivatePayloadQueryBuilder AddFieldAutomaticDiscountNode(Func<DiscountAutomaticNodeQueryBuilder, DiscountAutomaticNodeQueryBuilder> build)
    {
        AddField<DiscountAutomaticNode, DiscountAutomaticNodeQueryBuilder>("automaticDiscountNode", build);
        return this;
    }

    public DiscountAutomaticDeactivatePayloadQueryBuilder AddFieldUserErrors(Func<DiscountUserErrorQueryBuilder, DiscountUserErrorQueryBuilder> build)
    {
        AddField<DiscountUserError, DiscountUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}