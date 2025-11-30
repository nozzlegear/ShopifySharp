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

public class ShopPayPaymentRequestTotalShippingPriceQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestTotalShippingPrice>("shopPayPaymentRequestTotalShippingPrice")
{
    public ShopPayPaymentRequestTotalShippingPriceQueryBuilder AddFieldDiscounts(Func<ShopPayPaymentRequestDiscountQueryBuilder, ShopPayPaymentRequestDiscountQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequestDiscount, ShopPayPaymentRequestDiscountQueryBuilder>("discounts", build);
        return this;
    }

    public ShopPayPaymentRequestTotalShippingPriceQueryBuilder AddFieldFinalTotal(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("finalTotal", build);
        return this;
    }

    public ShopPayPaymentRequestTotalShippingPriceQueryBuilder AddFieldOriginalTotal(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("originalTotal", build);
        return this;
    }
}