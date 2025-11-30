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

public class FulfillmentOrderSubmitCancellationRequestPayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderSubmitCancellationRequestPayload>("query fulfillmentOrderSubmitCancellationRequestPayload")
{
    public FulfillmentOrderSubmitCancellationRequestPayloadQueryBuilder AddFieldFulfillmentOrder()
    {
        AddField("fulfillmentOrder");
        return this;
    }

    public FulfillmentOrderSubmitCancellationRequestPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}