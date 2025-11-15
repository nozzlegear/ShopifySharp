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

public class AbandonedCheckoutLineItemQueryBuilder() : GraphQueryBuilder<AbandonedCheckoutLineItem>("query abandonedCheckoutLineItem")
{
    public AbandonedCheckoutLineItemQueryBuilder AddFieldComponents()
    {
        AddField("components");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldCustomAttributes()
    {
        AddField("customAttributes");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldDiscountAllocations()
    {
        AddField("discountAllocations");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldDiscountedTotalPriceSet()
    {
        AddField("discountedTotalPriceSet");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldDiscountedTotalPriceWithCodeDiscount()
    {
        AddField("discountedTotalPriceWithCodeDiscount");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldDiscountedUnitPriceSet()
    {
        AddField("discountedUnitPriceSet");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldDiscountedUnitPriceWithCodeDiscount()
    {
        AddField("discountedUnitPriceWithCodeDiscount");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldImage()
    {
        AddField("image");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldOriginalTotalPriceSet()
    {
        AddField("originalTotalPriceSet");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldOriginalUnitPriceSet()
    {
        AddField("originalUnitPriceSet");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldSku()
    {
        AddField("sku");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldVariant()
    {
        AddField("variant");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldVariantTitle()
    {
        AddField("variantTitle");
        return this;
    }
}