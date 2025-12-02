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

public class ProductCompareAtPriceRangeQueryBuilder() : GraphQueryBuilder<ProductCompareAtPriceRange>("productCompareAtPriceRange")
{
    public ProductCompareAtPriceRangeQueryBuilder AddFieldMaxVariantCompareAtPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("maxVariantCompareAtPrice", build);
        return this;
    }

    public ProductCompareAtPriceRangeQueryBuilder AddFieldMinVariantCompareAtPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("minVariantCompareAtPrice", build);
        return this;
    }
}