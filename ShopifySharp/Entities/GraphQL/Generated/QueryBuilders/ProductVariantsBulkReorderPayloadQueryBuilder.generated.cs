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

public class ProductVariantsBulkReorderPayloadQueryBuilder() : GraphQueryBuilder<ProductVariantsBulkReorderPayload>("productVariantsBulkReorderPayload")
{
    public ProductVariantsBulkReorderPayloadQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductVariantsBulkReorderPayloadQueryBuilder AddFieldUserErrors(Func<ProductVariantsBulkReorderUserErrorQueryBuilder, ProductVariantsBulkReorderUserErrorQueryBuilder> build)
    {
        AddField<ProductVariantsBulkReorderUserError, ProductVariantsBulkReorderUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}