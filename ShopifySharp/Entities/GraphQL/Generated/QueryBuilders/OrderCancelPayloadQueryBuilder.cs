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

public class OrderCancelPayloadQueryBuilder() : GraphQueryBuilder<OrderCancelPayload>("query orderCancelPayload")
{
    public OrderCancelPayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public OrderCancelPayloadQueryBuilder AddFieldOrderCancelUserErrors()
    {
        AddField("orderCancelUserErrors");
        return this;
    }

    [Obsolete("Use `orderCancelUserErrors` instead.")]
    public OrderCancelPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}