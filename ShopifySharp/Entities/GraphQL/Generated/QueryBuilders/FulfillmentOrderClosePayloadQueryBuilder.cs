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

public class FulfillmentOrderClosePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderClosePayload>("query fulfillmentOrderClosePayload")
{
    public FulfillmentOrderClosePayloadQueryBuilder AddFieldFulfillmentOrder()
    {
        AddField("fulfillmentOrder");
        return this;
    }

    public FulfillmentOrderClosePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}