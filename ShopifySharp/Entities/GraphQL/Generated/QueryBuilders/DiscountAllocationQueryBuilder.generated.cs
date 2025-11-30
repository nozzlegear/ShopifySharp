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

public class DiscountAllocationQueryBuilder() : GraphQueryBuilder<DiscountAllocation>("discountAllocation")
{
    public DiscountAllocationQueryBuilder AddFieldAllocatedAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("allocatedAmount", build);
        return this;
    }

    public DiscountAllocationQueryBuilder AddFieldAllocatedAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("allocatedAmountSet", build);
        return this;
    }

    public DiscountAllocationQueryBuilder AddFieldDiscountApplication(Func<DiscountApplicationQueryBuilder, DiscountApplicationQueryBuilder> build)
    {
        AddField<IDiscountApplication, DiscountApplicationQueryBuilder>("discountApplication", build);
        return this;
    }
}