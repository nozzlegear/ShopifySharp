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

public class ShopPayPaymentRequestShippingLineQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestShippingLine>("shopPayPaymentRequestShippingLine")
{
    public ShopPayPaymentRequestShippingLineQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
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