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

public class OrderEditAddLineItemDiscountPayloadQueryBuilder() : GraphQueryBuilder<OrderEditAddLineItemDiscountPayload>("query orderEditAddLineItemDiscountPayload")
{
    public OrderEditAddLineItemDiscountPayloadQueryBuilder AddFieldAddedDiscountStagedChange()
    {
        AddField("addedDiscountStagedChange");
        return this;
    }

    public OrderEditAddLineItemDiscountPayloadQueryBuilder AddFieldCalculatedLineItem()
    {
        AddField("calculatedLineItem");
        return this;
    }

    public OrderEditAddLineItemDiscountPayloadQueryBuilder AddFieldCalculatedOrder()
    {
        AddField("calculatedOrder");
        return this;
    }

    public OrderEditAddLineItemDiscountPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}