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

public class ShopPayPaymentRequestLineItemQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestLineItem>("shopPayPaymentRequestLineItem")
{
    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldFinalItemPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("finalItemPrice", build);
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldFinalLinePrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("finalLinePrice", build);
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldImage(Func<ShopPayPaymentRequestImageQueryBuilder, ShopPayPaymentRequestImageQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequestImage, ShopPayPaymentRequestImageQueryBuilder>("image", build);
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldItemDiscounts(Func<ShopPayPaymentRequestDiscountQueryBuilder, ShopPayPaymentRequestDiscountQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequestDiscount, ShopPayPaymentRequestDiscountQueryBuilder>("itemDiscounts", build);
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldLabel()
    {
        AddField("label");
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldLineDiscounts(Func<ShopPayPaymentRequestDiscountQueryBuilder, ShopPayPaymentRequestDiscountQueryBuilder> build)
    {
        AddField<ShopPayPaymentRequestDiscount, ShopPayPaymentRequestDiscountQueryBuilder>("lineDiscounts", build);
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldOriginalItemPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("originalItemPrice", build);
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldOriginalLinePrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("originalLinePrice", build);
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldRequiresShipping()
    {
        AddField("requiresShipping");
        return this;
    }

    public ShopPayPaymentRequestLineItemQueryBuilder AddFieldSku()
    {
        AddField("sku");
        return this;
    }
}