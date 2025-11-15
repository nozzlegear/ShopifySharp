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

public class ProductOptionsCreatePayloadQueryBuilder() : GraphQueryBuilder<ProductOptionsCreatePayload>("query productOptionsCreatePayload")
{
    public ProductOptionsCreatePayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductOptionsCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}