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

public class ProductCreatePayloadQueryBuilder() : GraphQueryBuilder<ProductCreatePayload>("query productCreatePayload")
{
    public ProductCreatePayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductCreatePayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public ProductCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}