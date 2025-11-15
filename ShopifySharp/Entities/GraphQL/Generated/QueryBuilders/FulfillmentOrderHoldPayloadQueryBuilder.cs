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

public class FulfillmentOrderHoldPayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderHoldPayload>("query fulfillmentOrderHoldPayload")
{
    public FulfillmentOrderHoldPayloadQueryBuilder AddFieldFulfillmentHold()
    {
        AddField("fulfillmentHold");
        return this;
    }

    public FulfillmentOrderHoldPayloadQueryBuilder AddFieldFulfillmentOrder()
    {
        AddField("fulfillmentOrder");
        return this;
    }

    public FulfillmentOrderHoldPayloadQueryBuilder AddFieldRemainingFulfillmentOrder()
    {
        AddField("remainingFulfillmentOrder");
        return this;
    }

    public FulfillmentOrderHoldPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}