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

public class CalculatedLineItemQueryBuilder() : GraphQueryBuilder<CalculatedLineItem>("query calculatedLineItem")
{
    public CalculatedLineItemQueryBuilder AddFieldCalculatedDiscountAllocations()
    {
        AddField("calculatedDiscountAllocations");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldCustomAttributes()
    {
        AddField("customAttributes");
        return this;
    }

    [Obsolete("Use `calculatedDiscountAllocations` instead.")]
    public CalculatedLineItemQueryBuilder AddFieldDiscountAllocations()
    {
        AddField("discountAllocations");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldDiscountedUnitPriceSet()
    {
        AddField("discountedUnitPriceSet");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldEditableQuantity()
    {
        AddField("editableQuantity");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldEditableQuantityBeforeChanges()
    {
        AddField("editableQuantityBeforeChanges");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldEditableSubtotalSet()
    {
        AddField("editableSubtotalSet");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldHasStagedLineItemDiscount()
    {
        AddField("hasStagedLineItemDiscount");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldImage()
    {
        AddField("image");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldOriginalUnitPriceSet()
    {
        AddField("originalUnitPriceSet");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldRestockable()
    {
        AddField("restockable");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldRestocking()
    {
        AddField("restocking");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldSku()
    {
        AddField("sku");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldStagedChanges()
    {
        AddField("stagedChanges");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldUneditableSubtotalSet()
    {
        AddField("uneditableSubtotalSet");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldVariant()
    {
        AddField("variant");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldVariantTitle()
    {
        AddField("variantTitle");
        return this;
    }
}