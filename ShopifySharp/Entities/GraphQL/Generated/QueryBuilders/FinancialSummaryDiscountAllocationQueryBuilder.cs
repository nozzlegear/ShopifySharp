#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class FinancialSummaryDiscountAllocationQueryBuilder() : GraphQueryBuilder<FinancialSummaryDiscountAllocation>("query financialSummaryDiscountAllocation")
{
    public FinancialSummaryDiscountAllocationQueryBuilder AddFieldApproximateAllocatedAmountPerItem()
    {
        AddField("approximateAllocatedAmountPerItem");
        return this;
    }

    public FinancialSummaryDiscountAllocationQueryBuilder AddFieldDiscountApplication()
    {
        AddField("discountApplication");
        return this;
    }
}