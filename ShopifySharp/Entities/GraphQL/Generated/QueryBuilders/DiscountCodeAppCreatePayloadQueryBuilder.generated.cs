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

public class DiscountCodeAppCreatePayloadQueryBuilder() : GraphQueryBuilder<DiscountCodeAppCreatePayload>("discountCodeAppCreatePayload")
{
    public DiscountCodeAppCreatePayloadQueryBuilder AddFieldCodeAppDiscount(Func<DiscountCodeAppQueryBuilder, DiscountCodeAppQueryBuilder> build)
    {
        AddField<DiscountCodeApp, DiscountCodeAppQueryBuilder>("codeAppDiscount", build);
        return this;
    }

    public DiscountCodeAppCreatePayloadQueryBuilder AddFieldUserErrors(Func<DiscountUserErrorQueryBuilder, DiscountUserErrorQueryBuilder> build)
    {
        AddField<DiscountUserError, DiscountUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}