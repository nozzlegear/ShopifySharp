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

public class OrderClosePayloadQueryBuilder() : GraphQueryBuilder<OrderClosePayload>("query orderClosePayload")
{
    public OrderClosePayloadQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public OrderClosePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}