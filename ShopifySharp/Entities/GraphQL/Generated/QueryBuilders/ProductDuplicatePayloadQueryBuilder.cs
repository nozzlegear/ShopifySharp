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

public class ProductDuplicatePayloadQueryBuilder() : GraphQueryBuilder<ProductDuplicatePayload>("query productDuplicatePayload")
{
    public ProductDuplicatePayloadQueryBuilder AddFieldImageJob()
    {
        AddField("imageJob");
        return this;
    }

    public ProductDuplicatePayloadQueryBuilder AddFieldNewProduct()
    {
        AddField("newProduct");
        return this;
    }

    public ProductDuplicatePayloadQueryBuilder AddFieldProductDuplicateOperation()
    {
        AddField("productDuplicateOperation");
        return this;
    }

    public ProductDuplicatePayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public ProductDuplicatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}