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

public class ShippingRefundQueryBuilder() : GraphQueryBuilder<ShippingRefund>("shippingRefund")
{
    [Obsolete("Use `amountSet` instead.")]
    public ShippingRefundQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public ShippingRefundQueryBuilder AddFieldAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("amountSet", build);
        return this;
    }

    [Obsolete("Use `maximumRefundableSet` instead.")]
    public ShippingRefundQueryBuilder AddFieldMaximumRefundable()
    {
        AddField("maximumRefundable");
        return this;
    }

    public ShippingRefundQueryBuilder AddFieldMaximumRefundableSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("maximumRefundableSet", build);
        return this;
    }

    [Obsolete("Use `taxSet` instead.")]
    public ShippingRefundQueryBuilder AddFieldTax()
    {
        AddField("tax");
        return this;
    }

    public ShippingRefundQueryBuilder AddFieldTaxSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("taxSet", build);
        return this;
    }
}