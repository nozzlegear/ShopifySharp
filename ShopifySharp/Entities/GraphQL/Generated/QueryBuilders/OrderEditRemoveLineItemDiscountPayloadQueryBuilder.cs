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

public class OrderEditRemoveLineItemDiscountPayloadQueryBuilder() : GraphQueryBuilder<OrderEditRemoveLineItemDiscountPayload>("query orderEditRemoveLineItemDiscountPayload")
{
    public OrderEditRemoveLineItemDiscountPayloadQueryBuilder AddFieldCalculatedLineItem()
    {
        AddField("calculatedLineItem");
        return this;
    }

    public OrderEditRemoveLineItemDiscountPayloadQueryBuilder AddFieldCalculatedOrder()
    {
        AddField("calculatedOrder");
        return this;
    }

    public OrderEditRemoveLineItemDiscountPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}