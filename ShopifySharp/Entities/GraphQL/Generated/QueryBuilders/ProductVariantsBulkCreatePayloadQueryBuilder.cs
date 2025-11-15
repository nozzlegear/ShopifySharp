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

public class ProductVariantsBulkCreatePayloadQueryBuilder() : GraphQueryBuilder<ProductVariantsBulkCreatePayload>("query productVariantsBulkCreatePayload")
{
    public ProductVariantsBulkCreatePayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductVariantsBulkCreatePayloadQueryBuilder AddFieldProductVariants()
    {
        AddField("productVariants");
        return this;
    }

    public ProductVariantsBulkCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}