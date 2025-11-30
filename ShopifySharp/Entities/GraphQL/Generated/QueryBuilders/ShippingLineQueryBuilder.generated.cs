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

public class ShippingLineQueryBuilder() : GraphQueryBuilder<ShippingLine>("shippingLine")
{
    public ShippingLineQueryBuilder AddFieldCarrierIdentifier()
    {
        AddField("carrierIdentifier");
        return this;
    }

    public ShippingLineQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public ShippingLineQueryBuilder AddFieldCurrentDiscountedPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("currentDiscountedPriceSet", build);
        return this;
    }

    public ShippingLineQueryBuilder AddFieldCustom()
    {
        AddField("custom");
        return this;
    }

    public ShippingLineQueryBuilder AddFieldDeliveryCategory()
    {
        AddField("deliveryCategory");
        return this;
    }

    public ShippingLineQueryBuilder AddFieldDiscountAllocations(Func<DiscountAllocationQueryBuilder, DiscountAllocationQueryBuilder> build)
    {
        AddField<DiscountAllocation, DiscountAllocationQueryBuilder>("discountAllocations", build);
        return this;
    }

    public ShippingLineQueryBuilder AddFieldDiscountedPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("discountedPrice", build);
        return this;
    }

    public ShippingLineQueryBuilder AddFieldDiscountedPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedPriceSet", build);
        return this;
    }

    public ShippingLineQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShippingLineQueryBuilder AddFieldIsRemoved()
    {
        AddField("isRemoved");
        return this;
    }

    public ShippingLineQueryBuilder AddFieldOriginalPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("originalPrice", build);
        return this;
    }

    public ShippingLineQueryBuilder AddFieldOriginalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalPriceSet", build);
        return this;
    }

    public ShippingLineQueryBuilder AddFieldPhone()
    {
        AddField("phone");
        return this;
    }

    [Obsolete("Use `originalPriceSet` instead.")]
    public ShippingLineQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public ShippingLineQueryBuilder AddFieldRequestedFulfillmentService(Func<FulfillmentServiceQueryBuilder, FulfillmentServiceQueryBuilder> build)
    {
        AddField<FulfillmentService, FulfillmentServiceQueryBuilder>("requestedFulfillmentService", build);
        return this;
    }

    public ShippingLineQueryBuilder AddFieldShippingRateHandle()
    {
        AddField("shippingRateHandle");
        return this;
    }

    public ShippingLineQueryBuilder AddFieldSource()
    {
        AddField("source");
        return this;
    }

    public ShippingLineQueryBuilder AddFieldTaxLines(Func<TaxLineQueryBuilder, TaxLineQueryBuilder> build)
    {
        AddField<TaxLine, TaxLineQueryBuilder>("taxLines", build);
        return this;
    }

    public ShippingLineQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}