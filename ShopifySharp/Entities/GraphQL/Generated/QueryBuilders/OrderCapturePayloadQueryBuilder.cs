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

public class OrderCapturePayloadQueryBuilder() : GraphQueryBuilder<OrderCapturePayload>("query orderCapturePayload")
{
    public OrderCapturePayloadQueryBuilder AddFieldTransaction()
    {
        AddField("transaction");
        return this;
    }

    public OrderCapturePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}