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

public class OrderEditUpdateShippingLinePayloadQueryBuilder() : GraphQueryBuilder<OrderEditUpdateShippingLinePayload>("query orderEditUpdateShippingLinePayload")
{
    public OrderEditUpdateShippingLinePayloadQueryBuilder AddFieldCalculatedOrder()
    {
        AddField("calculatedOrder");
        return this;
    }

    public OrderEditUpdateShippingLinePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}