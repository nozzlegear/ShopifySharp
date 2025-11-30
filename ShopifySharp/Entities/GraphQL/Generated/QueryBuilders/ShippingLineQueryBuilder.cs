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

public class ShippingLineQueryBuilder() : GraphQueryBuilder<ShippingLine>("query shippingLine")
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

    public ShippingLineQueryBuilder AddFieldCurrentDiscountedPriceSet()
    {
        AddField("currentDiscountedPriceSet");
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

    public ShippingLineQueryBuilder AddFieldDiscountAllocations()
    {
        AddField("discountAllocations");
        return this;
    }

    [Obsolete("Use `discountedPriceSet` instead.")]
    public ShippingLineQueryBuilder AddFieldDiscountedPrice()
    {
        AddField("discountedPrice");
        return this;
    }

    public ShippingLineQueryBuilder AddFieldDiscountedPriceSet()
    {
        AddField("discountedPriceSet");
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

    [Obsolete("Use `originalPriceSet` instead.")]
    public ShippingLineQueryBuilder AddFieldOriginalPrice()
    {
        AddField("originalPrice");
        return this;
    }

    public ShippingLineQueryBuilder AddFieldOriginalPriceSet()
    {
        AddField("originalPriceSet");
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

    [Obsolete("requestedFulfillmentService is no longer in use. Order routing does not use the requestedFulfillmentService during order and fulfillment order creation.")]
    public ShippingLineQueryBuilder AddFieldRequestedFulfillmentService()
    {
        AddField("requestedFulfillmentService");
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

    public ShippingLineQueryBuilder AddFieldTaxLines()
    {
        AddField("taxLines");
        return this;
    }

    public ShippingLineQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}