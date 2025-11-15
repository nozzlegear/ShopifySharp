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

public class FulfillmentCreateV2PayloadQueryBuilder() : GraphQueryBuilder<FulfillmentCreateV2Payload>("query fulfillmentCreateV2Payload")
{
    public FulfillmentCreateV2PayloadQueryBuilder AddFieldFulfillment()
    {
        AddField("fulfillment");
        return this;
    }

    public FulfillmentCreateV2PayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}