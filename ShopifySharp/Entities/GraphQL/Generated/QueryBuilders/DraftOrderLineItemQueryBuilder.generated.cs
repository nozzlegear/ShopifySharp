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

public class DraftOrderLineItemQueryBuilder() : GraphQueryBuilder<DraftOrderLineItem>("draftOrderLineItem")
{
    public DraftOrderLineItemQueryBuilder AddFieldAppliedDiscount(Func<DraftOrderAppliedDiscountQueryBuilder, DraftOrderAppliedDiscountQueryBuilder> build)
    {
        AddField<DraftOrderAppliedDiscount, DraftOrderAppliedDiscountQueryBuilder>("appliedDiscount", build);
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldApproximateDiscountedUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("approximateDiscountedUnitPriceSet", build);
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldBundleComponents(Func<DraftOrderLineItemQueryBuilder, DraftOrderLineItemQueryBuilder> build)
    {
        AddField<DraftOrderLineItem, DraftOrderLineItemQueryBuilder>("bundleComponents", build);
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldComponents(Func<DraftOrderLineItemQueryBuilder, DraftOrderLineItemQueryBuilder> build)
    {
        AddField<DraftOrderLineItem, DraftOrderLineItemQueryBuilder>("components", build);
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldCustom()
    {
        AddField("custom");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldCustomAttributes(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("customAttributes", build);
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldCustomAttributesV2(Func<TypedAttributeQueryBuilder, TypedAttributeQueryBuilder> build)
    {
        AddField<TypedAttribute, TypedAttributeQueryBuilder>("customAttributesV2", build);
        return this;
    }

    [Obsolete("Use `discountedTotalSet` instead.")]
    public DraftOrderLineItemQueryBuilder AddFieldDiscountedTotal()
    {
        AddField("discountedTotal");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldDiscountedTotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedTotalSet", build);
        return this;
    }

    [Obsolete("Use `approximateDiscountedUnitPriceSet` instead.")]
    public DraftOrderLineItemQueryBuilder AddFieldDiscountedUnitPrice()
    {
        AddField("discountedUnitPrice");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldDiscountedUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedUnitPriceSet", build);
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldFulfillmentService(Func<FulfillmentServiceQueryBuilder, FulfillmentServiceQueryBuilder> build)
    {
        AddField<FulfillmentService, FulfillmentServiceQueryBuilder>("fulfillmentService", build);
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

    public DraftOrderLineItemQueryBuilder AddFieldImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("image", build);
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

    public DraftOrderLineItemQueryBuilder AddFieldOriginalTotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalTotalSet", build);
        return this;
    }

    [Obsolete("Use `originalUnitPriceWithCurrency` instead.")]
    public DraftOrderLineItemQueryBuilder AddFieldOriginalUnitPrice()
    {
        AddField("originalUnitPrice");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldOriginalUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalUnitPriceSet", build);
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldOriginalUnitPriceWithCurrency(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("originalUnitPriceWithCurrency", build);
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldPriceOverride(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("priceOverride", build);
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
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

    public DraftOrderLineItemQueryBuilder AddFieldTaxLines(Func<TaxLineQueryBuilder, TaxLineQueryBuilder> build)
    {
        AddField<TaxLine, TaxLineQueryBuilder>("taxLines", build);
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

    public DraftOrderLineItemQueryBuilder AddFieldTotalDiscountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountSet", build);
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldUuid()
    {
        AddField("uuid");
        return this;
    }

    public DraftOrderLineItemQueryBuilder AddFieldVariant(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("variant", build);
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

    public DraftOrderLineItemQueryBuilder AddFieldWeight(Func<WeightQueryBuilder, WeightQueryBuilder> build)
    {
        AddField<Weight, WeightQueryBuilder>("weight", build);
        return this;
    }
}