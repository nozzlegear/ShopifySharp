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

public class FulfillmentOrderMovePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderMovePayload>("query fulfillmentOrderMovePayload")
{
    public FulfillmentOrderMovePayloadQueryBuilder AddFieldMovedFulfillmentOrder()
    {
        AddField("movedFulfillmentOrder");
        return this;
    }

    public FulfillmentOrderMovePayloadQueryBuilder AddFieldOriginalFulfillmentOrder()
    {
        AddField("originalFulfillmentOrder");
        return this;
    }

    public FulfillmentOrderMovePayloadQueryBuilder AddFieldRemainingFulfillmentOrder()
    {
        AddField("remainingFulfillmentOrder");
        return this;
    }

    public FulfillmentOrderMovePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}