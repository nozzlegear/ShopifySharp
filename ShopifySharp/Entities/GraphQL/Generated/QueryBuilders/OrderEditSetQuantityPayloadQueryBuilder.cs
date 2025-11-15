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

public class OrderEditSetQuantityPayloadQueryBuilder() : GraphQueryBuilder<OrderEditSetQuantityPayload>("query orderEditSetQuantityPayload")
{
    public OrderEditSetQuantityPayloadQueryBuilder AddFieldCalculatedLineItem()
    {
        AddField("calculatedLineItem");
        return this;
    }

    public OrderEditSetQuantityPayloadQueryBuilder AddFieldCalculatedOrder()
    {
        AddField("calculatedOrder");
        return this;
    }

    public OrderEditSetQuantityPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}