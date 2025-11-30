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

public class CalculatedDraftOrderLineItemQueryBuilder() : GraphQueryBuilder<CalculatedDraftOrderLineItem>("calculatedDraftOrderLineItem")
{
    public CalculatedDraftOrderLineItemQueryBuilder AddFieldAppliedDiscount(Func<DraftOrderAppliedDiscountQueryBuilder, DraftOrderAppliedDiscountQueryBuilder> build)
    {
        AddField<DraftOrderAppliedDiscount, DraftOrderAppliedDiscountQueryBuilder>("appliedDiscount", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldApproximateDiscountedUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("approximateDiscountedUnitPriceSet", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldBundleComponents(Func<CalculatedDraftOrderLineItemQueryBuilder, CalculatedDraftOrderLineItemQueryBuilder> build)
    {
        AddField<CalculatedDraftOrderLineItem, CalculatedDraftOrderLineItemQueryBuilder>("bundleComponents", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldComponents(Func<CalculatedDraftOrderLineItemQueryBuilder, CalculatedDraftOrderLineItemQueryBuilder> build)
    {
        AddField<CalculatedDraftOrderLineItem, CalculatedDraftOrderLineItemQueryBuilder>("components", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldCustom()
    {
        AddField("custom");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldCustomAttributes(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("customAttributes", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldCustomAttributesV2(Func<TypedAttributeQueryBuilder, TypedAttributeQueryBuilder> build)
    {
        AddField<TypedAttribute, TypedAttributeQueryBuilder>("customAttributesV2", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldDiscountedTotal(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("discountedTotal", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldDiscountedTotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedTotalSet", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldDiscountedUnitPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("discountedUnitPrice", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldDiscountedUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedUnitPriceSet", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldFulfillmentService(Func<FulfillmentServiceQueryBuilder, FulfillmentServiceQueryBuilder> build)
    {
        AddField<FulfillmentService, FulfillmentServiceQueryBuilder>("fulfillmentService", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("image", build);
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

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldOriginalTotal(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("originalTotal", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldOriginalTotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalTotalSet", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldOriginalUnitPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("originalUnitPrice", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldOriginalUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalUnitPriceSet", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldOriginalUnitPriceWithCurrency(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("originalUnitPriceWithCurrency", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldPriceOverride(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("priceOverride", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
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

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldTotalDiscount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("totalDiscount", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldTotalDiscountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountSet", build);
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldUuid()
    {
        AddField("uuid");
        return this;
    }

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldVariant(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("variant", build);
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

    public CalculatedDraftOrderLineItemQueryBuilder AddFieldWeight(Func<WeightQueryBuilder, WeightQueryBuilder> build)
    {
        AddField<Weight, WeightQueryBuilder>("weight", build);
        return this;
    }
}