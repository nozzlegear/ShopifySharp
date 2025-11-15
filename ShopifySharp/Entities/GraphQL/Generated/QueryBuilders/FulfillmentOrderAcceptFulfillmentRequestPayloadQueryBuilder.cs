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

public class FulfillmentOrderAcceptFulfillmentRequestPayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderAcceptFulfillmentRequestPayload>("query fulfillmentOrderAcceptFulfillmentRequestPayload")
{
    public FulfillmentOrderAcceptFulfillmentRequestPayloadQueryBuilder AddFieldFulfillmentOrder()
    {
        AddField("fulfillmentOrder");
        return this;
    }

    public FulfillmentOrderAcceptFulfillmentRequestPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}