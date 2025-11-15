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

public class FulfillmentOrderLineItemFinancialSummaryQueryBuilder() : GraphQueryBuilder<FulfillmentOrderLineItemFinancialSummary>("query fulfillmentOrderLineItemFinancialSummary")
{
    public FulfillmentOrderLineItemFinancialSummaryQueryBuilder AddFieldApproximateDiscountedUnitPriceSet()
    {
        AddField("approximateDiscountedUnitPriceSet");
        return this;
    }

    public FulfillmentOrderLineItemFinancialSummaryQueryBuilder AddFieldDiscountAllocations()
    {
        AddField("discountAllocations");
        return this;
    }

    public FulfillmentOrderLineItemFinancialSummaryQueryBuilder AddFieldOriginalUnitPriceSet()
    {
        AddField("originalUnitPriceSet");
        return this;
    }

    public FulfillmentOrderLineItemFinancialSummaryQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }
}