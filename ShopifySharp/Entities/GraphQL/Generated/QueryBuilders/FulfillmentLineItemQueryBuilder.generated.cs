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

public class FulfillmentLineItemQueryBuilder() : GraphQueryBuilder<FulfillmentLineItem>("fulfillmentLineItem")
{
    [Obsolete("Use `discountedTotalSet` instead.")]
    public FulfillmentLineItemQueryBuilder AddFieldDiscountedTotal()
    {
        AddField("discountedTotal");
        return this;
    }

    public FulfillmentLineItemQueryBuilder AddFieldDiscountedTotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedTotalSet", build);
        return this;
    }

    public FulfillmentLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FulfillmentLineItemQueryBuilder AddFieldLineItem(Func<LineItemQueryBuilder, LineItemQueryBuilder> build)
    {
        AddField<LineItem, LineItemQueryBuilder>("lineItem", build);
        return this;
    }

    [Obsolete("Use `originalTotalSet` instead.")]
    public FulfillmentLineItemQueryBuilder AddFieldOriginalTotal()
    {
        AddField("originalTotal");
        return this;
    }

    public FulfillmentLineItemQueryBuilder AddFieldOriginalTotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalTotalSet", build);
        return this;
    }

    public FulfillmentLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }
}