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

public class FulfillmentOrderReschedulePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderReschedulePayload>("query fulfillmentOrderReschedulePayload")
{
    public FulfillmentOrderReschedulePayloadQueryBuilder AddFieldFulfillmentOrder()
    {
        AddField("fulfillmentOrder");
        return this;
    }

    public FulfillmentOrderReschedulePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}