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

public class PriceListPriceQueryBuilder() : GraphQueryBuilder<PriceListPrice>("priceListPrice")
{
    public PriceListPriceQueryBuilder AddFieldCompareAtPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("compareAtPrice", build);
        return this;
    }

    public PriceListPriceQueryBuilder AddFieldOriginType()
    {
        AddField("originType");
        return this;
    }

    public PriceListPriceQueryBuilder AddFieldPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("price", build);
        return this;
    }

    public PriceListPriceQueryBuilder AddFieldQuantityPriceBreaks(Func<QuantityPriceBreakConnectionQueryBuilder, QuantityPriceBreakConnectionQueryBuilder> build)
    {
        AddField<QuantityPriceBreakConnection, QuantityPriceBreakConnectionQueryBuilder>("quantityPriceBreaks", build);
        return this;
    }

    public PriceListPriceQueryBuilder AddFieldVariant(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("variant", build);
        return this;
    }
}