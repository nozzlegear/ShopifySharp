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

public class ProductVariantContextualPricingQueryBuilder() : GraphQueryBuilder<ProductVariantContextualPricing>("productVariantContextualPricing")
{
    public ProductVariantContextualPricingQueryBuilder AddFieldCompareAtPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("compareAtPrice", build);
        return this;
    }

    public ProductVariantContextualPricingQueryBuilder AddFieldPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("price", build);
        return this;
    }

    public ProductVariantContextualPricingQueryBuilder AddFieldQuantityPriceBreaks(Func<QuantityPriceBreakConnectionQueryBuilder, QuantityPriceBreakConnectionQueryBuilder> build)
    {
        AddField<QuantityPriceBreakConnection, QuantityPriceBreakConnectionQueryBuilder>("quantityPriceBreaks", build);
        return this;
    }

    public ProductVariantContextualPricingQueryBuilder AddFieldQuantityRule(Func<QuantityRuleQueryBuilder, QuantityRuleQueryBuilder> build)
    {
        AddField<QuantityRule, QuantityRuleQueryBuilder>("quantityRule", build);
        return this;
    }

    public ProductVariantContextualPricingQueryBuilder AddFieldUnitPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("unitPrice", build);
        return this;
    }
}