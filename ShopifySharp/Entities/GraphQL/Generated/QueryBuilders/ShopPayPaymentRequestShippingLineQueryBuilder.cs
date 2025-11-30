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

public class ShopPayPaymentRequestShippingLineQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestShippingLine>("query shopPayPaymentRequestShippingLine")
{
    public ShopPayPaymentRequestShippingLineQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public ShopPayPaymentRequestShippingLineQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ShopPayPaymentRequestShippingLineQueryBuilder AddFieldLabel()
    {
        AddField("label");
        return this;
    }
}