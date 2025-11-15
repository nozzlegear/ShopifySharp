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

public class FulfillmentOrderCancelPayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderCancelPayload>("query fulfillmentOrderCancelPayload")
{
    public FulfillmentOrderCancelPayloadQueryBuilder AddFieldFulfillmentOrder()
    {
        AddField("fulfillmentOrder");
        return this;
    }

    public FulfillmentOrderCancelPayloadQueryBuilder AddFieldReplacementFulfillmentOrder()
    {
        AddField("replacementFulfillmentOrder");
        return this;
    }

    public FulfillmentOrderCancelPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}