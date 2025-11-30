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

public class ProductSetPayloadQueryBuilder() : GraphQueryBuilder<ProductSetPayload>("query productSetPayload")
{
    public ProductSetPayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductSetPayloadQueryBuilder AddFieldProductSetOperation()
    {
        AddField("productSetOperation");
        return this;
    }

    public ProductSetPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}