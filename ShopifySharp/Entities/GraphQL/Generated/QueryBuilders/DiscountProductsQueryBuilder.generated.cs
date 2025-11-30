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

public class DiscountProductsQueryBuilder() : GraphQueryBuilder<DiscountProducts>("discountProducts")
{
    public DiscountProductsQueryBuilder AddFieldProducts(Func<ProductConnectionQueryBuilder, ProductConnectionQueryBuilder> build)
    {
        AddField<ProductConnection, ProductConnectionQueryBuilder>("products", build);
        return this;
    }

    public DiscountProductsQueryBuilder AddFieldProductVariants(Func<ProductVariantConnectionQueryBuilder, ProductVariantConnectionQueryBuilder> build)
    {
        AddField<ProductVariantConnection, ProductVariantConnectionQueryBuilder>("productVariants", build);
        return this;
    }
}