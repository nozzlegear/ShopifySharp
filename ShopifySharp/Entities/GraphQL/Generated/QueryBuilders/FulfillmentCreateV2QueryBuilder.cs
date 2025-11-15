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

[Obsolete("Use `fulfillmentCreate` instead.")]
public class FulfillmentCreateV2QueryBuilder() : GraphQueryBuilder<FulfillmentCreateV2Payload>("query fulfillmentCreateV2")
{
    public FulfillmentCreateV2QueryBuilder AddArgumentFulfillment(FulfillmentV2Input? fulfillment)
    {
        AddArgument("fulfillment", fulfillment);
        return this;
    }

    public FulfillmentCreateV2QueryBuilder AddArgumentMessage(string? message)
    {
        AddArgument("message", message);
        return this;
    }
}