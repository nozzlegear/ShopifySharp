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

public class RefundShippingLineQueryBuilder() : GraphQueryBuilder<RefundShippingLine>("refundShippingLine")
{
    public RefundShippingLineQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public RefundShippingLineQueryBuilder AddFieldShippingLine(Func<ShippingLineQueryBuilder, ShippingLineQueryBuilder> build)
    {
        AddField<ShippingLine, ShippingLineQueryBuilder>("shippingLine", build);
        return this;
    }

    public RefundShippingLineQueryBuilder AddFieldSubtotalAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("subtotalAmountSet", build);
        return this;
    }

    public RefundShippingLineQueryBuilder AddFieldTaxAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("taxAmountSet", build);
        return this;
    }
}