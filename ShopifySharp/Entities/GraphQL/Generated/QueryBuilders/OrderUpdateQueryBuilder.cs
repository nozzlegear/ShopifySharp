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

public class OrderUpdateQueryBuilder() : GraphQueryBuilder<OrderUpdatePayload>("query orderUpdate")
{
    public OrderUpdateQueryBuilder AddArgumentInput(OrderInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}