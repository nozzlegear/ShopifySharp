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

public class FulfillmentOrderSubmitFulfillmentRequestPayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderSubmitFulfillmentRequestPayload>("query fulfillmentOrderSubmitFulfillmentRequestPayload")
{
    public FulfillmentOrderSubmitFulfillmentRequestPayloadQueryBuilder AddFieldOriginalFulfillmentOrder()
    {
        AddField("originalFulfillmentOrder");
        return this;
    }

    public FulfillmentOrderSubmitFulfillmentRequestPayloadQueryBuilder AddFieldSubmittedFulfillmentOrder()
    {
        AddField("submittedFulfillmentOrder");
        return this;
    }

    public FulfillmentOrderSubmitFulfillmentRequestPayloadQueryBuilder AddFieldUnsubmittedFulfillmentOrder()
    {
        AddField("unsubmittedFulfillmentOrder");
        return this;
    }

    public FulfillmentOrderSubmitFulfillmentRequestPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}