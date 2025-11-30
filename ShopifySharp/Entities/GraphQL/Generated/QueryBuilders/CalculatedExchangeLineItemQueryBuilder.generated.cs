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

public class CalculatedExchangeLineItemQueryBuilder() : GraphQueryBuilder<CalculatedExchangeLineItem>("calculatedExchangeLineItem")
{
    public CalculatedExchangeLineItemQueryBuilder AddFieldCalculatedDiscountAllocations(Func<CalculatedDiscountAllocationQueryBuilder, CalculatedDiscountAllocationQueryBuilder> build)
    {
        AddField<CalculatedDiscountAllocation, CalculatedDiscountAllocationQueryBuilder>("calculatedDiscountAllocations", build);
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldDiscountedUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedUnitPriceSet", build);
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldOriginalUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalUnitPriceSet", build);
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldSubtotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("subtotalSet", build);
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldTotalTaxSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTaxSet", build);
        return this;
    }

    public CalculatedExchangeLineItemQueryBuilder AddFieldVariant(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("variant", build);
        return this;
    }
}