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

public class ReturnLineItemQueryBuilder() : GraphQueryBuilder<ReturnLineItem>("returnLineItem")
{
    public ReturnLineItemQueryBuilder AddFieldCustomerNote()
    {
        AddField("customerNote");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldFulfillmentLineItem(Func<FulfillmentLineItemQueryBuilder, FulfillmentLineItemQueryBuilder> build)
    {
        AddField<FulfillmentLineItem, FulfillmentLineItemQueryBuilder>("fulfillmentLineItem", build);
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldProcessableQuantity()
    {
        AddField("processableQuantity");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldProcessedQuantity()
    {
        AddField("processedQuantity");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldRefundableQuantity()
    {
        AddField("refundableQuantity");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldRefundedQuantity()
    {
        AddField("refundedQuantity");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldRestockingFee(Func<RestockingFeeQueryBuilder, RestockingFeeQueryBuilder> build)
    {
        AddField<RestockingFee, RestockingFeeQueryBuilder>("restockingFee", build);
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldReturnReason()
    {
        AddField("returnReason");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldReturnReasonNote()
    {
        AddField("returnReasonNote");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldTotalWeight(Func<WeightQueryBuilder, WeightQueryBuilder> build)
    {
        AddField<Weight, WeightQueryBuilder>("totalWeight", build);
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldUnprocessedQuantity()
    {
        AddField("unprocessedQuantity");
        return this;
    }

    public ReturnLineItemQueryBuilder AddFieldWithCodeDiscountedTotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("withCodeDiscountedTotalPriceSet", build);
        return this;
    }
}