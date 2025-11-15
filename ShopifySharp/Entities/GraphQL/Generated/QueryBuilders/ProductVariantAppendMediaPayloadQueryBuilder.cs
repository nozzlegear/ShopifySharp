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

public class ProductVariantAppendMediaPayloadQueryBuilder() : GraphQueryBuilder<ProductVariantAppendMediaPayload>("query productVariantAppendMediaPayload")
{
    public ProductVariantAppendMediaPayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductVariantAppendMediaPayloadQueryBuilder AddFieldProductVariants()
    {
        AddField("productVariants");
        return this;
    }

    public ProductVariantAppendMediaPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}