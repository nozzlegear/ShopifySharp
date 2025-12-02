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

public class QuantityPriceBreakQueryBuilder() : GraphQueryBuilder<QuantityPriceBreak>("quantityPriceBreak")
{
    public QuantityPriceBreakQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public QuantityPriceBreakQueryBuilder AddFieldMinimumQuantity()
    {
        AddField("minimumQuantity");
        return this;
    }

    public QuantityPriceBreakQueryBuilder AddFieldPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("price", build);
        return this;
    }

    public QuantityPriceBreakQueryBuilder AddFieldPriceList(Func<PriceListQueryBuilder, PriceListQueryBuilder> build)
    {
        AddField<PriceList, PriceListQueryBuilder>("priceList", build);
        return this;
    }

    public QuantityPriceBreakQueryBuilder AddFieldVariant(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("variant", build);
        return this;
    }
}