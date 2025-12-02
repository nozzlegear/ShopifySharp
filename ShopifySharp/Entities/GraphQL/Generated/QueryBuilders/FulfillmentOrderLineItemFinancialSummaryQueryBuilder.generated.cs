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

public class FulfillmentOrderLineItemFinancialSummaryQueryBuilder() : GraphQueryBuilder<FulfillmentOrderLineItemFinancialSummary>("fulfillmentOrderLineItemFinancialSummary")
{
    public FulfillmentOrderLineItemFinancialSummaryQueryBuilder AddFieldApproximateDiscountedUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("approximateDiscountedUnitPriceSet", build);
        return this;
    }

    public FulfillmentOrderLineItemFinancialSummaryQueryBuilder AddFieldDiscountAllocations(Func<FinancialSummaryDiscountAllocationQueryBuilder, FinancialSummaryDiscountAllocationQueryBuilder> build)
    {
        AddField<FinancialSummaryDiscountAllocation, FinancialSummaryDiscountAllocationQueryBuilder>("discountAllocations", build);
        return this;
    }

    public FulfillmentOrderLineItemFinancialSummaryQueryBuilder AddFieldOriginalUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalUnitPriceSet", build);
        return this;
    }

    public FulfillmentOrderLineItemFinancialSummaryQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }
}