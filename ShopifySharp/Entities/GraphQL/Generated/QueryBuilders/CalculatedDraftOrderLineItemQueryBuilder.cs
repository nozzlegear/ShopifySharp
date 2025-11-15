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

public class CalculatedDraftOrderLineItemQueryBuilder() : GraphQueryBuilder<CalculatedDraftOrderLineItem>("query calculatedDraftOrderLineItem")
{
    public CalculatedDraftOrderLineItemQueryBuilder AddFieldAppliedDiscount()
    {
        AddField("appliedDiscount");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldApproximateDiscountedUnitPriceSet()
    {
        AddField("approximateDiscountedUnitPriceSet");
        return this;
    }

    [Obsolete("Use `components` instead.")]
    public CalculatedDraftOrderLineItemQueryBuilder AddFieldBundleComponents()
    {
        AddField("bundleComponents");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldComponents()
    {
        AddField("components");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldCustom()
    {
        AddField("custom");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldCustomAttributes()
    {
        AddField("customAttributes");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldCustomAttributesV2()
    {
        AddField("customAttributesV2");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldDiscountedTotal()
    {
        AddField("discountedTotal");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldDiscountedTotalSet()
    {
        AddField("discountedTotalSet");
        return this;
    }

    [Obsolete("Use `approximateDiscountedUnitPriceSet` instead.")]
    public CalculatedDraftOrderLineItemQueryBuilder AddFieldDiscountedUnitPrice()
    {
        AddField("discountedUnitPrice");
        return this;
    }

    [Obsolete("Use `approximateDiscountedUnitPriceSet` instead.")]
    public CalculatedDraftOrderLineItemQueryBuilder AddFieldDiscountedUnitPriceSet()
    {
        AddField("discountedUnitPriceSet");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldFulfillmentService()
    {
        AddField("fulfillmentService");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldImage()
    {
        AddField("image");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldIsGiftCard()
    {
        AddField("isGiftCard");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldOriginalTotal()
    {
        AddField("originalTotal");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldOriginalTotalSet()
    {
        AddField("originalTotalSet");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldOriginalUnitPrice()
    {
        AddField("originalUnitPrice");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldOriginalUnitPriceSet()
    {
        AddField("originalUnitPriceSet");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldOriginalUnitPriceWithCurrency()
    {
        AddField("originalUnitPriceWithCurrency");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldPriceOverride()
    {
        AddField("priceOverride");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldRequiresShipping()
    {
        AddField("requiresShipping");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldSku()
    {
        AddField("sku");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldTaxable()
    {
        AddField("taxable");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldTotalDiscount()
    {
        AddField("totalDiscount");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldTotalDiscountSet()
    {
        AddField("totalDiscountSet");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldUuid()
    {
        AddField("uuid");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldVariant()
    {
        AddField("variant");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldVariantTitle()
    {
        AddField("variantTitle");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldVendor()
    {
        AddField("vendor");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldWeight()
    {
        AddField("weight");
        return this;
    }
}