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

public class DiscountAutomaticAppCreatePayloadQueryBuilder() : GraphQueryBuilder<DiscountAutomaticAppCreatePayload>("discountAutomaticAppCreatePayload")
{
    public DiscountAutomaticAppCreatePayloadQueryBuilder AddFieldAutomaticAppDiscount(Func<DiscountAutomaticAppQueryBuilder, DiscountAutomaticAppQueryBuilder> build)
    {
        AddField<DiscountAutomaticApp, DiscountAutomaticAppQueryBuilder>("automaticAppDiscount", build);
        return this;
    }

    public DiscountAutomaticAppCreatePayloadQueryBuilder AddFieldUserErrors(Func<DiscountUserErrorQueryBuilder, DiscountUserErrorQueryBuilder> build)
    {
        AddField<DiscountUserError, DiscountUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}