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

public class LineItemQueryBuilder() : GraphQueryBuilder<LineItem>("lineItem")
{
    [Obsolete("Use `restockable` instead.")]
    public LineItemQueryBuilder AddFieldCanRestock()
    {
        AddField("canRestock");
        return this;
    }

    public LineItemQueryBuilder AddFieldContract(Func<SubscriptionContractQueryBuilder, SubscriptionContractQueryBuilder> build)
    {
        AddField<SubscriptionContract, SubscriptionContractQueryBuilder>("contract", build);
        return this;
    }

    public LineItemQueryBuilder AddFieldCurrentQuantity()
    {
        AddField("currentQuantity");
        return this;
    }

    public LineItemQueryBuilder AddFieldCustomAttributes(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("customAttributes", build);
        return this;
    }

    public LineItemQueryBuilder AddFieldDiscountAllocations(Func<DiscountAllocationQueryBuilder, DiscountAllocationQueryBuilder> build)
    {
        AddField<DiscountAllocation, DiscountAllocationQueryBuilder>("discountAllocations", build);
        return this;
    }

    [Obsolete("Use `discountedTotalSet` instead.")]
    public LineItemQueryBuilder AddFieldDiscountedTotal()
    {
        AddField("discountedTotal");
        return this;
    }

    public LineItemQueryBuilder AddFieldDiscountedTotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedTotalSet", build);
        return this;
    }

    [Obsolete("Use `discountedUnitPriceSet` instead.")]
    public LineItemQueryBuilder AddFieldDiscountedUnitPrice()
    {
        AddField("discountedUnitPrice");
        return this;
    }

    public LineItemQueryBuilder AddFieldDiscountedUnitPriceAfterAllDiscountsSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedUnitPriceAfterAllDiscountsSet", build);
        return this;
    }

    public LineItemQueryBuilder AddFieldDiscountedUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedUnitPriceSet", build);
        return this;
    }

    public LineItemQueryBuilder AddFieldDuties(Func<DutyQueryBuilder, DutyQueryBuilder> build)
    {
        AddField<Duty, DutyQueryBuilder>("duties", build);
        return this;
    }

    [Obsolete("Use [FulfillmentOrderLineItem#remainingQuantity](https://shopify.dev/api/admin-graphql/latest/objects/FulfillmentOrderLineItem#field-fulfillmentorderlineitem-remainingquantity) instead.")]
    public LineItemQueryBuilder AddFieldFulfillableQuantity()
    {
        AddField("fulfillableQuantity");
        return this;
    }

    public LineItemQueryBuilder AddFieldFulfillmentService(Func<FulfillmentServiceQueryBuilder, FulfillmentServiceQueryBuilder> build)
    {
        AddField<FulfillmentService, FulfillmentServiceQueryBuilder>("fulfillmentService", build);
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

    public LineItemQueryBuilder AddFieldImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("image", build);
        return this;
    }

    public LineItemQueryBuilder AddFieldIsGiftCard()
    {
        AddField("isGiftCard");
        return this;
    }

    public LineItemQueryBuilder AddFieldLineItemGroup(Func<LineItemGroupQueryBuilder, LineItemGroupQueryBuilder> build)
    {
        AddField<LineItemGroup, LineItemGroupQueryBuilder>("lineItemGroup", build);
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

    public LineItemQueryBuilder AddFieldOriginalTotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalTotalSet", build);
        return this;
    }

    [Obsolete("Use `originalUnitPriceSet` instead.")]
    public LineItemQueryBuilder AddFieldOriginalUnitPrice()
    {
        AddField("originalUnitPrice");
        return this;
    }

    public LineItemQueryBuilder AddFieldOriginalUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalUnitPriceSet", build);
        return this;
    }

    public LineItemQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
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

    public LineItemQueryBuilder AddFieldSellingPlan(Func<LineItemSellingPlanQueryBuilder, LineItemSellingPlanQueryBuilder> build)
    {
        AddField<LineItemSellingPlan, LineItemSellingPlanQueryBuilder>("sellingPlan", build);
        return this;
    }

    public LineItemQueryBuilder AddFieldSku()
    {
        AddField("sku");
        return this;
    }

    public LineItemQueryBuilder AddFieldStaffMember(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("staffMember", build);
        return this;
    }

    public LineItemQueryBuilder AddFieldTaxable()
    {
        AddField("taxable");
        return this;
    }

    public LineItemQueryBuilder AddFieldTaxLines(Func<TaxLineQueryBuilder, TaxLineQueryBuilder> build)
    {
        AddField<TaxLine, TaxLineQueryBuilder>("taxLines", build);
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

    public LineItemQueryBuilder AddFieldTotalDiscountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountSet", build);
        return this;
    }

    [Obsolete("Use `unfulfilledDiscountedTotalSet` instead.")]
    public LineItemQueryBuilder AddFieldUnfulfilledDiscountedTotal()
    {
        AddField("unfulfilledDiscountedTotal");
        return this;
    }

    public LineItemQueryBuilder AddFieldUnfulfilledDiscountedTotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("unfulfilledDiscountedTotalSet", build);
        return this;
    }

    [Obsolete("Use `unfulfilledOriginalTotalSet` instead.")]
    public LineItemQueryBuilder AddFieldUnfulfilledOriginalTotal()
    {
        AddField("unfulfilledOriginalTotal");
        return this;
    }

    public LineItemQueryBuilder AddFieldUnfulfilledOriginalTotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("unfulfilledOriginalTotalSet", build);
        return this;
    }

    public LineItemQueryBuilder AddFieldUnfulfilledQuantity()
    {
        AddField("unfulfilledQuantity");
        return this;
    }

    public LineItemQueryBuilder AddFieldVariant(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("variant", build);
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