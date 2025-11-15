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

public class ProductPriceRangeQueryBuilder() : GraphQueryBuilder<ProductPriceRange>("query productPriceRange")
{
    public ProductPriceRangeQueryBuilder AddFieldMaxVariantPrice()
    {
        AddField("maxVariantPrice");
        return this;
    }

    public ProductPriceRangeQueryBuilder AddFieldMinVariantPrice()
    {
        AddField("minVariantPrice");
        return this;
    }
}