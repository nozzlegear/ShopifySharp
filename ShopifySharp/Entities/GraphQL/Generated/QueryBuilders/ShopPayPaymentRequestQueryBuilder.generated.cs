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

public class ShopPayPaymentRequestQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequest>("shopPayPaymentRequest")
{
    public ShopPayPaymentRequestQueryBuilder AddFieldDiscounts(Func<ShopPayPaymentRequestDiscountQueryBuilder, ShopPayPaymentRequestDiscountQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequestDiscount, ShopPayPaymentRequestDiscountQueryBuilder>("discounts", build);
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldLineItems(Func<ShopPayPaymentRequestLineItemQueryBuilder, ShopPayPaymentRequestLineItemQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequestLineItem, ShopPayPaymentRequestLineItemQueryBuilder>("lineItems", build);
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldPresentmentCurrency()
    {
        AddField("presentmentCurrency");
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldSelectedDeliveryMethodType()
    {
        AddField("selectedDeliveryMethodType");
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldShippingAddress(Func<ShopPayPaymentRequestContactFieldQueryBuilder, ShopPayPaymentRequestContactFieldQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequestContactField, ShopPayPaymentRequestContactFieldQueryBuilder>("shippingAddress", build);
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldShippingLines(Func<ShopPayPaymentRequestShippingLineQueryBuilder, ShopPayPaymentRequestShippingLineQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequestShippingLine, ShopPayPaymentRequestShippingLineQueryBuilder>("shippingLines", build);
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldSubtotal(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("subtotal", build);
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldTotal(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("total", build);
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldTotalShippingPrice(Func<ShopPayPaymentRequestTotalShippingPriceQueryBuilder, ShopPayPaymentRequestTotalShippingPriceQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequestTotalShippingPrice, ShopPayPaymentRequestTotalShippingPriceQueryBuilder>("totalShippingPrice", build);
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldTotalTax(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("totalTax", build);
        return this;
    }
}