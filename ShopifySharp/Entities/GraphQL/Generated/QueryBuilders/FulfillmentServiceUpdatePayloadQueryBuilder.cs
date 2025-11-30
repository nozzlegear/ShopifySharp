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

public class FulfillmentServiceUpdatePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentServiceUpdatePayload>("query fulfillmentServiceUpdatePayload")
{
    public FulfillmentServiceUpdatePayloadQueryBuilder AddFieldFulfillmentService()
    {
        AddField("fulfillmentService");
        return this;
    }

    public FulfillmentServiceUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}