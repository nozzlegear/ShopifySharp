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

public class FulfillmentCreatePayloadQueryBuilder() : GraphQueryBuilder<FulfillmentCreatePayload>("query fulfillmentCreatePayload")
{
    public FulfillmentCreatePayloadQueryBuilder AddFieldFulfillment()
    {
        AddField("fulfillment");
        return this;
    }

    public FulfillmentCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}