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

public class ProductVariantDetachMediaPayloadQueryBuilder() : GraphQueryBuilder<ProductVariantDetachMediaPayload>("productVariantDetachMediaPayload")
{
    public ProductVariantDetachMediaPayloadQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductVariantDetachMediaPayloadQueryBuilder AddFieldProductVariants(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("productVariants", build);
        return this;
    }

    public ProductVariantDetachMediaPayloadQueryBuilder AddFieldUserErrors(Func<MediaUserErrorQueryBuilder, MediaUserErrorQueryBuilder> build)
    {
        AddField<MediaUserError, MediaUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}