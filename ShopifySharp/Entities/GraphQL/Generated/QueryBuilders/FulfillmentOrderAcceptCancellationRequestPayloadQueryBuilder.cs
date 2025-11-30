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

public class FulfillmentOrderAcceptCancellationRequestPayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderAcceptCancellationRequestPayload>("query fulfillmentOrderAcceptCancellationRequestPayload")
{
    public FulfillmentOrderAcceptCancellationRequestPayloadQueryBuilder AddFieldFulfillmentOrder()
    {
        AddField("fulfillmentOrder");
        return this;
    }

    public FulfillmentOrderAcceptCancellationRequestPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}