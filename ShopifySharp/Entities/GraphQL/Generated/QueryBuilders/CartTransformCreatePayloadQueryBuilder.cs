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

public class CartTransformCreatePayloadQueryBuilder() : GraphQueryBuilder<CartTransformCreatePayload>("query cartTransformCreatePayload")
{
    public CartTransformCreatePayloadQueryBuilder AddFieldCartTransform()
    {
        AddField("cartTransform");
        return this;
    }

    public CartTransformCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}