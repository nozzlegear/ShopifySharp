#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ProductVariantsBulkCreatePayloadQueryBuilder() : GraphQueryBuilder<ProductVariantsBulkCreatePayload>("productVariantsBulkCreatePayload")
{
    public ProductVariantsBulkCreatePayloadQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductVariantsBulkCreatePayloadQueryBuilder AddFieldProductVariants(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("productVariants", build);
        return this;
    }

    public ProductVariantsBulkCreatePayloadQueryBuilder AddFieldUserErrors(Func<ProductVariantsBulkCreateUserErrorQueryBuilder, ProductVariantsBulkCreateUserErrorQueryBuilder> build)
    {
        AddField<ProductVariantsBulkCreateUserError, ProductVariantsBulkCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}