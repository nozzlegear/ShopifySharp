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

public class CalculatedLineItemQueryBuilder() : GraphQueryBuilder<CalculatedLineItem>("calculatedLineItem")
{
    public CalculatedLineItemQueryBuilder AddFieldCalculatedDiscountAllocations(Func<CalculatedDiscountAllocationQueryBuilder, CalculatedDiscountAllocationQueryBuilder> build)
    {
        AddField<CalculatedDiscountAllocation, CalculatedDiscountAllocationQueryBuilder>("calculatedDiscountAllocations", build);
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldCustomAttributes(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("customAttributes", build);
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldDiscountAllocations(Func<DiscountAllocationQueryBuilder, DiscountAllocationQueryBuilder> build)
    {
        AddField<DiscountAllocation, DiscountAllocationQueryBuilder>("discountAllocations", build);
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldDiscountedUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedUnitPriceSet", build);
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

    public CalculatedLineItemQueryBuilder AddFieldEditableSubtotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("editableSubtotalSet", build);
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

    public CalculatedLineItemQueryBuilder AddFieldImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("image", build);
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldOriginalUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalUnitPriceSet", build);
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

    public CalculatedLineItemQueryBuilder AddUnionCaseStagedChanges(Func<OrderStagedChangeAddCustomItemQueryBuilder, OrderStagedChangeAddCustomItemQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeAddCustomItem, OrderStagedChangeAddCustomItemQueryBuilder>("stagedChanges", build);
        return this;
    }

    public CalculatedLineItemQueryBuilder AddUnionCaseStagedChanges(Func<OrderStagedChangeAddLineItemDiscountQueryBuilder, OrderStagedChangeAddLineItemDiscountQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeAddLineItemDiscount, OrderStagedChangeAddLineItemDiscountQueryBuilder>("stagedChanges", build);
        return this;
    }

    public CalculatedLineItemQueryBuilder AddUnionCaseStagedChanges(Func<OrderStagedChangeAddShippingLineQueryBuilder, OrderStagedChangeAddShippingLineQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeAddShippingLine, OrderStagedChangeAddShippingLineQueryBuilder>("stagedChanges", build);
        return this;
    }

    public CalculatedLineItemQueryBuilder AddUnionCaseStagedChanges(Func<OrderStagedChangeAddVariantQueryBuilder, OrderStagedChangeAddVariantQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeAddVariant, OrderStagedChangeAddVariantQueryBuilder>("stagedChanges", build);
        return this;
    }

    public CalculatedLineItemQueryBuilder AddUnionCaseStagedChanges(Func<OrderStagedChangeDecrementItemQueryBuilder, OrderStagedChangeDecrementItemQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeDecrementItem, OrderStagedChangeDecrementItemQueryBuilder>("stagedChanges", build);
        return this;
    }

    public CalculatedLineItemQueryBuilder AddUnionCaseStagedChanges(Func<OrderStagedChangeIncrementItemQueryBuilder, OrderStagedChangeIncrementItemQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeIncrementItem, OrderStagedChangeIncrementItemQueryBuilder>("stagedChanges", build);
        return this;
    }

    public CalculatedLineItemQueryBuilder AddUnionCaseStagedChanges(Func<OrderStagedChangeRemoveShippingLineQueryBuilder, OrderStagedChangeRemoveShippingLineQueryBuilder> build)
    {
        AddUnion<OrderStagedChangeRemoveShippingLine, OrderStagedChangeRemoveShippingLineQueryBuilder>("stagedChanges", build);
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldUneditableSubtotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("uneditableSubtotalSet", build);
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldVariant(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("variant", build);
        return this;
    }

    public CalculatedLineItemQueryBuilder AddFieldVariantTitle()
    {
        AddField("variantTitle");
        return this;
    }
}