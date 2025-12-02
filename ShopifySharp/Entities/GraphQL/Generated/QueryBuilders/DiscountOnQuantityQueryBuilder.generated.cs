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

public class DiscountOnQuantityQueryBuilder() : GraphQueryBuilder<DiscountOnQuantity>("discountOnQuantity")
{
    public DiscountOnQuantityQueryBuilder AddUnionCaseEffect(Func<DiscountAmountQueryBuilder, DiscountAmountQueryBuilder> build)
    {
        AddUnion<DiscountAmount, DiscountAmountQueryBuilder>("effect", build);
        return this;
    }

    public DiscountOnQuantityQueryBuilder AddUnionCaseEffect(Func<DiscountPercentageQueryBuilder, DiscountPercentageQueryBuilder> build)
    {
        AddUnion<DiscountPercentage, DiscountPercentageQueryBuilder>("effect", build);
        return this;
    }

    public DiscountOnQuantityQueryBuilder AddFieldQuantity(Func<DiscountQuantityQueryBuilder, DiscountQuantityQueryBuilder> build)
    {
        AddField<DiscountQuantity, DiscountQuantityQueryBuilder>("quantity", build);
        return this;
    }
}