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

public class FulfillmentTrackingInfoUpdatePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentTrackingInfoUpdatePayload>("query fulfillmentTrackingInfoUpdatePayload")
{
    public FulfillmentTrackingInfoUpdatePayloadQueryBuilder AddFieldFulfillment()
    {
        AddField("fulfillment");
        return this;
    }

    public FulfillmentTrackingInfoUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}