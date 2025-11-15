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

public class FulfillmentServiceCreatePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentServiceCreatePayload>("query fulfillmentServiceCreatePayload")
{
    public FulfillmentServiceCreatePayloadQueryBuilder AddFieldFulfillmentService()
    {
        AddField("fulfillmentService");
        return this;
    }

    public FulfillmentServiceCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}