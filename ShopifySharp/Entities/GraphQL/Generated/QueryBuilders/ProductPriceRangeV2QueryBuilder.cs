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

public class ProductPriceRangeV2QueryBuilder() : GraphQueryBuilder<ProductPriceRangeV2>("query productPriceRangeV2")
{
    public ProductPriceRangeV2QueryBuilder AddFieldMaxVariantPrice()
    {
        AddField("maxVariantPrice");
        return this;
    }

    public ProductPriceRangeV2QueryBuilder AddFieldMinVariantPrice()
    {
        AddField("minVariantPrice");
        return this;
    }
}