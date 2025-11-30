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

public class CalculatedReturnLineItemQueryBuilder() : GraphQueryBuilder<CalculatedReturnLineItem>("calculatedReturnLineItem")
{
    public CalculatedReturnLineItemQueryBuilder AddFieldFulfillmentLineItem(Func<FulfillmentLineItemQueryBuilder, FulfillmentLineItemQueryBuilder> build)
    {
        AddField<FulfillmentLineItem, FulfillmentLineItemQueryBuilder>("fulfillmentLineItem", build);
        return this;
    }

    public CalculatedReturnLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedReturnLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public CalculatedReturnLineItemQueryBuilder AddFieldRestockingFee(Func<CalculatedRestockingFeeQueryBuilder, CalculatedRestockingFeeQueryBuilder> build)
    {
        AddField<CalculatedRestockingFee, CalculatedRestockingFeeQueryBuilder>("restockingFee", build);
        return this;
    }

    public CalculatedReturnLineItemQueryBuilder AddFieldSubtotalBeforeOrderDiscountsSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("subtotalBeforeOrderDiscountsSet", build);
        return this;
    }

    public CalculatedReturnLineItemQueryBuilder AddFieldSubtotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("subtotalSet", build);
        return this;
    }

    public CalculatedReturnLineItemQueryBuilder AddFieldTotalTaxSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTaxSet", build);
        return this;
    }
}