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

public class ShopPayPaymentRequestDiscountQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestDiscount>("query shopPayPaymentRequestDiscount")
{
    public ShopPayPaymentRequestDiscountQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public ShopPayPaymentRequestDiscountQueryBuilder AddFieldLabel()
    {
        AddField("label");
        return this;
    }
}