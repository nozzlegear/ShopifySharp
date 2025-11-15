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

public class ShopPayPaymentRequestQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequest>("query shopPayPaymentRequest")
{
    public ShopPayPaymentRequestQueryBuilder AddFieldDiscounts()
    {
        AddField("discounts");
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldLineItems()
    {
        AddField("lineItems");
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

    public ShopPayPaymentRequestQueryBuilder AddFieldShippingAddress()
    {
        AddField("shippingAddress");
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldShippingLines()
    {
        AddField("shippingLines");
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldSubtotal()
    {
        AddField("subtotal");
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldTotal()
    {
        AddField("total");
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldTotalShippingPrice()
    {
        AddField("totalShippingPrice");
        return this;
    }

    public ShopPayPaymentRequestQueryBuilder AddFieldTotalTax()
    {
        AddField("totalTax");
        return this;
    }
}