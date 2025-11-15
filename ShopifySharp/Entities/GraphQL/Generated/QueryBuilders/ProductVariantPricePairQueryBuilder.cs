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

public class ProductVariantPricePairQueryBuilder() : GraphQueryBuilder<ProductVariantPricePair>("query productVariantPricePair")
{
    public ProductVariantPricePairQueryBuilder AddFieldCompareAtPrice()
    {
        AddField("compareAtPrice");
        return this;
    }

    public ProductVariantPricePairQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }
}