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

public class ProductContextualPricingQueryBuilder() : GraphQueryBuilder<ProductContextualPricing>("productContextualPricing")
{
    public ProductContextualPricingQueryBuilder AddFieldFixedQuantityRulesCount()
    {
        AddField("fixedQuantityRulesCount");
        return this;
    }

    public ProductContextualPricingQueryBuilder AddFieldMaxVariantPricing(Func<ProductVariantContextualPricingQueryBuilder, ProductVariantContextualPricingQueryBuilder> build)
    {
        AddField<ProductVariantContextualPricing, ProductVariantContextualPricingQueryBuilder>("maxVariantPricing", build);
        return this;
    }

    public ProductContextualPricingQueryBuilder AddFieldMinVariantPricing(Func<ProductVariantContextualPricingQueryBuilder, ProductVariantContextualPricingQueryBuilder> build)
    {
        AddField<ProductVariantContextualPricing, ProductVariantContextualPricingQueryBuilder>("minVariantPricing", build);
        return this;
    }

    public ProductContextualPricingQueryBuilder AddFieldPriceRange(Func<ProductPriceRangeV2QueryBuilder, ProductPriceRangeV2QueryBuilder> build)
    {
        AddField<ProductPriceRangeV2, ProductPriceRangeV2QueryBuilder>("priceRange", build);
        return this;
    }
}