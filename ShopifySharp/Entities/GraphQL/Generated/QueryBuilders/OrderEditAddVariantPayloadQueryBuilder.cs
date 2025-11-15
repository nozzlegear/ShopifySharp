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

public class OrderEditAddVariantPayloadQueryBuilder() : GraphQueryBuilder<OrderEditAddVariantPayload>("query orderEditAddVariantPayload")
{
    public OrderEditAddVariantPayloadQueryBuilder AddFieldCalculatedLineItem()
    {
        AddField("calculatedLineItem");
        return this;
    }

    public OrderEditAddVariantPayloadQueryBuilder AddFieldCalculatedOrder()
    {
        AddField("calculatedOrder");
        return this;
    }

    public OrderEditAddVariantPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}