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

public class LineItemQueryBuilder() : GraphQueryBuilder<LineItem>("query lineItem")
{
    [Obsolete("Use `restockable` instead.")]
    public LineItemQueryBuilder AddFieldCanRestock()
    {
        AddField("canRestock");
        return this;
    }

    public LineItemQueryBuilder AddFieldContract()
    {
        AddField("contract");
        return this;
    }

    public LineItemQueryBuilder AddFieldCurrentQuantity()
    {
        AddField("currentQuantity");
        return this;
    }

    public LineItemQueryBuilder AddFieldCustomAttributes()
    {
        AddField("customAttributes");
        return this;
    }

    public LineItemQueryBuilder AddFieldDiscountAllocations()
    {
        AddField("discountAllocations");
        return this;
    }

    [Obsolete("Use `discountedTotalSet` instead.")]
    public LineItemQueryBuilder AddFieldDiscountedTotal()
    {
        AddField("discountedTotal");
        return this;
    }

    public LineItemQueryBuilder AddFieldDiscountedTotalSet()
    {
        AddField("discountedTotalSet");
        return this;
    }

    [Obsolete("Use `discountedUnitPriceSet` instead.")]
    public LineItemQueryBuilder AddFieldDiscountedUnitPrice()
    {
        AddField("discountedUnitPrice");
        return this;
    }

    public LineItemQueryBuilder AddFieldDiscountedUnitPriceAfterAllDiscountsSet()
    {
        AddField("discountedUnitPriceAfterAllDiscountsSet");
        return this;
    }

    public LineItemQueryBuilder AddFieldDiscountedUnitPriceSet()
    {
        AddField("discountedUnitPriceSet");
        return this;
    }

    public LineItemQueryBuilder AddFieldDuties()
    {
        AddField("duties");
        return this;
    }

    [Obsolete("Use [FulfillmentOrderLineItem#remainingQuantity](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentOrderLineItem#field-fulfillmentorderlineitem-remainingquantity) instead.")]
    public LineItemQueryBuilder AddFieldFulfillableQuantity()
    {
        AddField("fulfillableQuantity");
        return this;
    }

    [Obsolete(" The [relationship between a product variant and a fulfillment service was changed](/changelog/fulfillment-service-sku-sharing). A [ProductVariant](/api/admin-graphql/latest/objects/ProductVariant) can be stocked by multiple fulfillment services. As a result, we recommend that you use the [inventoryItem field](/api/admin-graphql/latest/objects/ProductVariant#field-productvariant-inventoryitem) if you need to determine where a product variant is stocked.  If you need to determine whether a product is a gift card, then you should continue to use this field until an alternative is available.  Altering the locations which stock a product variant wont change the value of this field for existing orders.  Learn about [managing inventory quantities and states](/apps/fulfillment/inventory-management-apps/quantities-states). ")]
    public LineItemQueryBuilder AddFieldFulfillmentService()
    {
        AddField("fulfillmentService");
        return this;
    }

    [Obsolete("Use [FulfillmentOrderLineItem#remainingQuantity](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentOrderLineItem#field-fulfillmentorderlineitem-remainingquantity) instead")]
    public LineItemQueryBuilder AddFieldFulfillmentStatus()
    {
        AddField("fulfillmentStatus");
        return this;
    }

    public LineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public LineItemQueryBuilder AddFieldImage()
    {
        AddField("image");
        return this;
    }

    public LineItemQueryBuilder AddFieldIsGiftCard()
    {
        AddField("isGiftCard");
        return this;
    }

    public LineItemQueryBuilder AddFieldLineItemGroup()
    {
        AddField("lineItemGroup");
        return this;
    }

    public LineItemQueryBuilder AddFieldMerchantEditable()
    {
        AddField("merchantEditable");
        return this;
    }

    public LineItemQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public LineItemQueryBuilder AddFieldNonFulfillableQuantity()
    {
        AddField("nonFulfillableQuantity");
        return this;
    }

    [Obsolete("Use `originalTotalSet` instead.")]
    public LineItemQueryBuilder AddFieldOriginalTotal()
    {
        AddField("originalTotal");
        return this;
    }

    public LineItemQueryBuilder AddFieldOriginalTotalSet()
    {
        AddField("originalTotalSet");
        return this;
    }

    [Obsolete("Use `originalUnitPriceSet` instead.")]
    public LineItemQueryBuilder AddFieldOriginalUnitPrice()
    {
        AddField("originalUnitPrice");
        return this;
    }

    public LineItemQueryBuilder AddFieldOriginalUnitPriceSet()
    {
        AddField("originalUnitPriceSet");
        return this;
    }

    public LineItemQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public LineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public LineItemQueryBuilder AddFieldRefundableQuantity()
    {
        AddField("refundableQuantity");
        return this;
    }

    public LineItemQueryBuilder AddFieldRequiresShipping()
    {
        AddField("requiresShipping");
        return this;
    }

    public LineItemQueryBuilder AddFieldRestockable()
    {
        AddField("restockable");
        return this;
    }

    public LineItemQueryBuilder AddFieldSellingPlan()
    {
        AddField("sellingPlan");
        return this;
    }

    public LineItemQueryBuilder AddFieldSku()
    {
        AddField("sku");
        return this;
    }

    public LineItemQueryBuilder AddFieldStaffMember()
    {
        AddField("staffMember");
        return this;
    }

    public LineItemQueryBuilder AddFieldTaxable()
    {
        AddField("taxable");
        return this;
    }

    public LineItemQueryBuilder AddFieldTaxLines()
    {
        AddField("taxLines");
        return this;
    }

    public LineItemQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    [Obsolete("Use `totalDiscountSet` instead.")]
    public LineItemQueryBuilder AddFieldTotalDiscount()
    {
        AddField("totalDiscount");
        return this;
    }

    public LineItemQueryBuilder AddFieldTotalDiscountSet()
    {
        AddField("totalDiscountSet");
        return this;
    }

    [Obsolete("Use `unfulfilledDiscountedTotalSet` instead.")]
    public LineItemQueryBuilder AddFieldUnfulfilledDiscountedTotal()
    {
        AddField("unfulfilledDiscountedTotal");
        return this;
    }

    public LineItemQueryBuilder AddFieldUnfulfilledDiscountedTotalSet()
    {
        AddField("unfulfilledDiscountedTotalSet");
        return this;
    }

    [Obsolete("Use `unfulfilledOriginalTotalSet` instead.")]
    public LineItemQueryBuilder AddFieldUnfulfilledOriginalTotal()
    {
        AddField("unfulfilledOriginalTotal");
        return this;
    }

    public LineItemQueryBuilder AddFieldUnfulfilledOriginalTotalSet()
    {
        AddField("unfulfilledOriginalTotalSet");
        return this;
    }

    public LineItemQueryBuilder AddFieldUnfulfilledQuantity()
    {
        AddField("unfulfilledQuantity");
        return this;
    }

    public LineItemQueryBuilder AddFieldVariant()
    {
        AddField("variant");
        return this;
    }

    public LineItemQueryBuilder AddFieldVariantTitle()
    {
        AddField("variantTitle");
        return this;
    }

    public LineItemQueryBuilder AddFieldVendor()
    {
        AddField("vendor");
        return this;
    }
}