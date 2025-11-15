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

public class OrderEditAddShippingLinePayloadQueryBuilder() : GraphQueryBuilder<OrderEditAddShippingLinePayload>("query orderEditAddShippingLinePayload")
{
    public OrderEditAddShippingLinePayloadQueryBuilder AddFieldCalculatedOrder()
    {
        AddField("calculatedOrder");
        return this;
    }

    public OrderEditAddShippingLinePayloadQueryBuilder AddFieldCalculatedShippingLine()
    {
        AddField("calculatedShippingLine");
        return this;
    }

    public OrderEditAddShippingLinePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}