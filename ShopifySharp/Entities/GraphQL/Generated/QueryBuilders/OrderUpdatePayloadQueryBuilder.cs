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

public class OrderUpdatePayloadQueryBuilder() : GraphQueryBuilder<OrderUpdatePayload>("query orderUpdatePayload")
{
    public OrderUpdatePayloadQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public OrderUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}