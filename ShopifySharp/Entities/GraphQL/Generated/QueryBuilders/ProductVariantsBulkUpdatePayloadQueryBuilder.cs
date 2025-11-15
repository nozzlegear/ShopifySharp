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

public class ProductVariantsBulkUpdatePayloadQueryBuilder() : GraphQueryBuilder<ProductVariantsBulkUpdatePayload>("query productVariantsBulkUpdatePayload")
{
    public ProductVariantsBulkUpdatePayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductVariantsBulkUpdatePayloadQueryBuilder AddFieldProductVariants()
    {
        AddField("productVariants");
        return this;
    }

    public ProductVariantsBulkUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}