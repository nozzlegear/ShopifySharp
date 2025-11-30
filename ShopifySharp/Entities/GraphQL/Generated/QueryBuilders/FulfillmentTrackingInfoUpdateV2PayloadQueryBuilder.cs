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

public class FulfillmentTrackingInfoUpdateV2PayloadQueryBuilder() : GraphQueryBuilder<FulfillmentTrackingInfoUpdateV2Payload>("query fulfillmentTrackingInfoUpdateV2Payload")
{
    public FulfillmentTrackingInfoUpdateV2PayloadQueryBuilder AddFieldFulfillment()
    {
        AddField("fulfillment");
        return this;
    }

    public FulfillmentTrackingInfoUpdateV2PayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}