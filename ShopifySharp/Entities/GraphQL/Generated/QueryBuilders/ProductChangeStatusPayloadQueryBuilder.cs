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

public class ProductChangeStatusPayloadQueryBuilder() : GraphQueryBuilder<ProductChangeStatusPayload>("query productChangeStatusPayload")
{
    public ProductChangeStatusPayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductChangeStatusPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}