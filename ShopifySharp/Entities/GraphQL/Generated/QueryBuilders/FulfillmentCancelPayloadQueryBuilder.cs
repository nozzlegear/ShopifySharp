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

public class FulfillmentCancelPayloadQueryBuilder() : GraphQueryBuilder<FulfillmentCancelPayload>("query fulfillmentCancelPayload")
{
    public FulfillmentCancelPayloadQueryBuilder AddFieldFulfillment()
    {
        AddField("fulfillment");
        return this;
    }

    public FulfillmentCancelPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}