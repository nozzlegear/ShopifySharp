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

public class FulfillmentOrderRejectCancellationRequestPayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderRejectCancellationRequestPayload>("query fulfillmentOrderRejectCancellationRequestPayload")
{
    public FulfillmentOrderRejectCancellationRequestPayloadQueryBuilder AddFieldFulfillmentOrder()
    {
        AddField("fulfillmentOrder");
        return this;
    }

    public FulfillmentOrderRejectCancellationRequestPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}