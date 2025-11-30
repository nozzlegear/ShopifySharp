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

public class FinancialSummaryDiscountAllocationQueryBuilder() : GraphQueryBuilder<FinancialSummaryDiscountAllocation>("financialSummaryDiscountAllocation")
{
    public FinancialSummaryDiscountAllocationQueryBuilder AddFieldApproximateAllocatedAmountPerItem(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("approximateAllocatedAmountPerItem", build);
        return this;
    }

    public FinancialSummaryDiscountAllocationQueryBuilder AddFieldDiscountApplication(Func<FinancialSummaryDiscountApplicationQueryBuilder, FinancialSummaryDiscountApplicationQueryBuilder> build)
    {
        AddField<FinancialSummaryDiscountApplication, FinancialSummaryDiscountApplicationQueryBuilder>("discountApplication", build);
        return this;
    }
}