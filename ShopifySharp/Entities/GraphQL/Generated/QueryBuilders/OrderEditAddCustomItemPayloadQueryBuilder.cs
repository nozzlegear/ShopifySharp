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

public class OrderEditAddCustomItemPayloadQueryBuilder() : GraphQueryBuilder<OrderEditAddCustomItemPayload>("query orderEditAddCustomItemPayload")
{
    public OrderEditAddCustomItemPayloadQueryBuilder AddFieldCalculatedLineItem()
    {
        AddField("calculatedLineItem");
        return this;
    }

    public OrderEditAddCustomItemPayloadQueryBuilder AddFieldCalculatedOrder()
    {
        AddField("calculatedOrder");
        return this;
    }

    public OrderEditAddCustomItemPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}