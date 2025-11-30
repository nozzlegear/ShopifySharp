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

public class ProductContextualPricingQueryBuilder() : GraphQueryBuilder<ProductContextualPricing>("query productContextualPricing")
{
    public ProductContextualPricingQueryBuilder AddFieldFixedQuantityRulesCount()
    {
        AddField("fixedQuantityRulesCount");
        return this;
    }

    public ProductContextualPricingQueryBuilder AddFieldMaxVariantPricing()
    {
        AddField("maxVariantPricing");
        return this;
    }

    public ProductContextualPricingQueryBuilder AddFieldMinVariantPricing()
    {
        AddField("minVariantPricing");
        return this;
    }

    public ProductContextualPricingQueryBuilder AddFieldPriceRange()
    {
        AddField("priceRange");
        return this;
    }
}