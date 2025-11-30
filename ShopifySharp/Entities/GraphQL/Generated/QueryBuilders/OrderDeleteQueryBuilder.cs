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

public class OrderDeleteQueryBuilder() : GraphQueryBuilder<OrderDeletePayload>("query orderDelete")
{
    public OrderDeleteQueryBuilder AddArgumentOrderId(string? orderId)
    {
        AddArgument("orderId", orderId);
        return this;
    }
}