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

public class RefundShippingLineQueryBuilder() : GraphQueryBuilder<RefundShippingLine>("query refundShippingLine")
{
    public RefundShippingLineQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public RefundShippingLineQueryBuilder AddFieldShippingLine()
    {
        AddField("shippingLine");
        return this;
    }

    public RefundShippingLineQueryBuilder AddFieldSubtotalAmountSet()
    {
        AddField("subtotalAmountSet");
        return this;
    }

    public RefundShippingLineQueryBuilder AddFieldTaxAmountSet()
    {
        AddField("taxAmountSet");
        return this;
    }
}