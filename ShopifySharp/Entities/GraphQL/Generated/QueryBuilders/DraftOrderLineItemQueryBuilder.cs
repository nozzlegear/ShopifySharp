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

public class DraftOrderLineItemQueryBuilder() : GraphQueryBuilder<DraftOrderLineItem>("query draftOrderLineItem")
{
    public DraftOrderLineItemQueryBuilder AddFieldAppliedDiscount()
    {
        AddField("appliedDiscount");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldApproximateDiscountedUnitPriceSet()
    {
        AddField("approximateDiscountedUnitPriceSet");
        return this;
    }

    [Obsolete("Use `components` instead.")]
    public DraftOrderLineItemQueryBuilder AddFieldBundleComponents()
    {
        AddField("bundleComponents");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldComponents()
    {
        AddField("components");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldCustom()
    {
        AddField("custom");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldCustomAttributes()
    {
        AddField("customAttributes");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldCustomAttributesV2()
    {
        AddField("customAttributesV2");
        return this;
    }

    [Obsolete("Use `discountedTotalSet` instead.")]
    public DraftOrderLineItemQueryBuilder AddFieldDiscountedTotal()
    {
        AddField("discountedTotal");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldDiscountedTotalSet()
    {
        AddField("discountedTotalSet");
        return this;
    }

    [Obsolete("Use `approximateDiscountedUnitPriceSet` instead.")]
    public DraftOrderLineItemQueryBuilder AddFieldDiscountedUnitPrice()
    {
        AddField("discountedUnitPrice");
        return this;
    }

    [Obsolete("Use `approximateDiscountedUnitPriceSet` instead.")]
    public DraftOrderLineItemQueryBuilder AddFieldDiscountedUnitPriceSet()
    {
        AddField("discountedUnitPriceSet");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldFulfillmentService()
    {
        AddField("fulfillmentService");
        return this;
    }

    [Obsolete("Use `weight` instead.")]
    public DraftOrderLineItemQueryBuilder AddFieldGrams()
    {
        AddField("grams");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldImage()
    {
        AddField("image");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldIsGiftCard()
    {
        AddField("isGiftCard");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    [Obsolete("Use `originalTotalSet` instead.")]
    public DraftOrderLineItemQueryBuilder AddFieldOriginalTotal()
    {
        AddField("originalTotal");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldOriginalTotalSet()
    {
        AddField("originalTotalSet");
        return this;
    }

    [Obsolete("Use `originalUnitPriceWithCurrency` instead.")]
    public DraftOrderLineItemQueryBuilder AddFieldOriginalUnitPrice()
    {
        AddField("originalUnitPrice");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldOriginalUnitPriceSet()
    {
        AddField("originalUnitPriceSet");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldOriginalUnitPriceWithCurrency()
    {
        AddField("originalUnitPriceWithCurrency");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldPriceOverride()
    {
        AddField("priceOverride");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldRequiresShipping()
    {
        AddField("requiresShipping");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldSku()
    {
        AddField("sku");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldTaxable()
    {
        AddField("taxable");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldTaxLines()
    {
        AddField("taxLines");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    [Obsolete("Use `totalDiscountSet` instead.")]
    public DraftOrderLineItemQueryBuilder AddFieldTotalDiscount()
    {
        AddField("totalDiscount");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldTotalDiscountSet()
    {
        AddField("totalDiscountSet");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldUuid()
    {
        AddField("uuid");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldVariant()
    {
        AddField("variant");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldVariantTitle()
    {
        AddField("variantTitle");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldVendor()
    {
        AddField("vendor");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldWeight()
    {
        AddField("weight");
        return this;
    }
}