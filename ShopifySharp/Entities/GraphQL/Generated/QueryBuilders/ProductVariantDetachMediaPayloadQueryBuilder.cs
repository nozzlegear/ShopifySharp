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

public class ProductVariantDetachMediaPayloadQueryBuilder() : GraphQueryBuilder<ProductVariantDetachMediaPayload>("query productVariantDetachMediaPayload")
{
    public ProductVariantDetachMediaPayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductVariantDetachMediaPayloadQueryBuilder AddFieldProductVariants()
    {
        AddField("productVariants");
        return this;
    }

    public ProductVariantDetachMediaPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}