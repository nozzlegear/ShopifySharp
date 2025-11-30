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

public class RefundCreatePayloadQueryBuilder() : GraphQueryBuilder<RefundCreatePayload>("query refundCreatePayload")
{
    public RefundCreatePayloadQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public RefundCreatePayloadQueryBuilder AddFieldRefund()
    {
        AddField("refund");
        return this;
    }

    public RefundCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}