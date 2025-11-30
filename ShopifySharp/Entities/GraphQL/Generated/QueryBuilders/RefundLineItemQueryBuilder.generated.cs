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

public class RefundLineItemQueryBuilder() : GraphQueryBuilder<RefundLineItem>("refundLineItem")
{
    public RefundLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldLineItem(Func<LineItemQueryBuilder, LineItemQueryBuilder> build)
    {
        AddField<LineItem, LineItemQueryBuilder>("lineItem", build);
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("location", build);
        return this;
    }

    [Obsolete("Use `priceSet` instead.")]
    public RefundLineItemQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("priceSet", build);
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldRestocked()
    {
        AddField("restocked");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldRestockType()
    {
        AddField("restockType");
        return this;
    }

    [Obsolete("Use `subtotalSet` instead.")]
    public RefundLineItemQueryBuilder AddFieldSubtotal()
    {
        AddField("subtotal");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldSubtotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("subtotalSet", build);
        return this;
    }

    [Obsolete("Use `totalTaxSet` instead.")]
    public RefundLineItemQueryBuilder AddFieldTotalTax()
    {
        AddField("totalTax");
        return this;
    }

    public RefundLineItemQueryBuilder AddFieldTotalTaxSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTaxSet", build);
        return this;
    }
}