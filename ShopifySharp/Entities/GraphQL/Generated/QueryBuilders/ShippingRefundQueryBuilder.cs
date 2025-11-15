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

public class ShippingRefundQueryBuilder() : GraphQueryBuilder<ShippingRefund>("query shippingRefund")
{
    [Obsolete("Use `amountSet` instead.")]
    public ShippingRefundQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public ShippingRefundQueryBuilder AddFieldAmountSet()
    {
        AddField("amountSet");
        return this;
    }

    [Obsolete("Use `maximumRefundableSet` instead.")]
    public ShippingRefundQueryBuilder AddFieldMaximumRefundable()
    {
        AddField("maximumRefundable");
        return this;
    }

    public ShippingRefundQueryBuilder AddFieldMaximumRefundableSet()
    {
        AddField("maximumRefundableSet");
        return this;
    }

    [Obsolete("Use `taxSet` instead.")]
    public ShippingRefundQueryBuilder AddFieldTax()
    {
        AddField("tax");
        return this;
    }

    public ShippingRefundQueryBuilder AddFieldTaxSet()
    {
        AddField("taxSet");
        return this;
    }
}