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

public class OrderEditRemoveDiscountPayloadQueryBuilder() : GraphQueryBuilder<OrderEditRemoveDiscountPayload>("query orderEditRemoveDiscountPayload")
{
    public OrderEditRemoveDiscountPayloadQueryBuilder AddFieldCalculatedOrder()
    {
        AddField("calculatedOrder");
        return this;
    }

    public OrderEditRemoveDiscountPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}