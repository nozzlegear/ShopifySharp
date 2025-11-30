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

public class FulfillmentCreateQueryBuilder() : GraphQueryBuilder<FulfillmentCreatePayload>("query fulfillmentCreate")
{
    public FulfillmentCreateQueryBuilder AddArgumentFulfillment(FulfillmentInput? fulfillment)
    {
        AddArgument("fulfillment", fulfillment);
        return this;
    }

    public FulfillmentCreateQueryBuilder AddArgumentMessage(string? message)
    {
        AddArgument("message", message);
        return this;
    }
}