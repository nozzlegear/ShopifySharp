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

public class ProductPriceRangeV2QueryBuilder() : GraphQueryBuilder<ProductPriceRangeV2>("productPriceRangeV2")
{
    public ProductPriceRangeV2QueryBuilder AddFieldMaxVariantPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("maxVariantPrice", build);
        return this;
    }

    public ProductPriceRangeV2QueryBuilder AddFieldMinVariantPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("minVariantPrice", build);
        return this;
    }
}