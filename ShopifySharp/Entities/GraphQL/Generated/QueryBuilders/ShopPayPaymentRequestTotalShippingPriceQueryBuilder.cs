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

public class ShopPayPaymentRequestTotalShippingPriceQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestTotalShippingPrice>("query shopPayPaymentRequestTotalShippingPrice")
{
    public ShopPayPaymentRequestTotalShippingPriceQueryBuilder AddFieldDiscounts()
    {
        AddField("discounts");
        return this;
    }

    public ShopPayPaymentRequestTotalShippingPriceQueryBuilder AddFieldFinalTotal()
    {
        AddField("finalTotal");
        return this;
    }

    public ShopPayPaymentRequestTotalShippingPriceQueryBuilder AddFieldOriginalTotal()
    {
        AddField("originalTotal");
        return this;
    }
}