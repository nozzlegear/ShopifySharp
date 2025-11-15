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

public class ProductVariantContextualPricingQueryBuilder() : GraphQueryBuilder<ProductVariantContextualPricing>("query productVariantContextualPricing")
{
    public ProductVariantContextualPricingQueryBuilder AddFieldCompareAtPrice()
    {
        AddField("compareAtPrice");
        return this;
    }

    public ProductVariantContextualPricingQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public ProductVariantContextualPricingQueryBuilder AddFieldQuantityPriceBreaks()
    {
        AddField("quantityPriceBreaks");
        return this;
    }

    public ProductVariantContextualPricingQueryBuilder AddFieldQuantityRule()
    {
        AddField("quantityRule");
        return this;
    }

    public ProductVariantContextualPricingQueryBuilder AddFieldUnitPrice()
    {
        AddField("unitPrice");
        return this;
    }
}