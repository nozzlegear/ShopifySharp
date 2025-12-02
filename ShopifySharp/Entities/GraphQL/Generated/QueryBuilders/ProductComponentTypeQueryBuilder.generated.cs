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

public class ProductComponentTypeQueryBuilder() : GraphQueryBuilder<ProductComponentType>("productComponentType")
{
    public ProductComponentTypeQueryBuilder AddFieldComponentVariants(Func<ProductVariantConnectionQueryBuilder, ProductVariantConnectionQueryBuilder> build)
    {
        AddField<ProductVariantConnection, ProductVariantConnectionQueryBuilder>("componentVariants", build);
        return this;
    }

    public ProductComponentTypeQueryBuilder AddFieldComponentVariantsCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("componentVariantsCount", build);
        return this;
    }

    public ProductComponentTypeQueryBuilder AddFieldNonComponentVariants(Func<ProductVariantConnectionQueryBuilder, ProductVariantConnectionQueryBuilder> build)
    {
        AddField<ProductVariantConnection, ProductVariantConnectionQueryBuilder>("nonComponentVariants", build);
        return this;
    }

    public ProductComponentTypeQueryBuilder AddFieldNonComponentVariantsCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("nonComponentVariantsCount", build);
        return this;
    }

    public ProductComponentTypeQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }
}