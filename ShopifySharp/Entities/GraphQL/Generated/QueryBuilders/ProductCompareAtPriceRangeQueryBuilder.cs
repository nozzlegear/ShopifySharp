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

public class ProductCompareAtPriceRangeQueryBuilder() : GraphQueryBuilder<ProductCompareAtPriceRange>("query productCompareAtPriceRange")
{
    public ProductCompareAtPriceRangeQueryBuilder AddFieldMaxVariantCompareAtPrice()
    {
        AddField("maxVariantCompareAtPrice");
        return this;
    }

    public ProductCompareAtPriceRangeQueryBuilder AddFieldMinVariantCompareAtPrice()
    {
        AddField("minVariantCompareAtPrice");
        return this;
    }
}