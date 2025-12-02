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

public class AbandonedCheckoutLineItemQueryBuilder() : GraphQueryBuilder<AbandonedCheckoutLineItem>("abandonedCheckoutLineItem")
{
    public AbandonedCheckoutLineItemQueryBuilder AddFieldComponents(Func<AbandonedCheckoutLineItemComponentQueryBuilder, AbandonedCheckoutLineItemComponentQueryBuilder> build)
    {
        AddField<AbandonedCheckoutLineItemComponent, AbandonedCheckoutLineItemComponentQueryBuilder>("components", build);
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldCustomAttributes(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("customAttributes", build);
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldDiscountAllocations(Func<DiscountAllocationConnectionQueryBuilder, DiscountAllocationConnectionQueryBuilder> build)
    {
        AddField<DiscountAllocationConnection, DiscountAllocationConnectionQueryBuilder>("discountAllocations", build);
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldDiscountedTotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedTotalPriceSet", build);
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldDiscountedTotalPriceWithCodeDiscount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedTotalPriceWithCodeDiscount", build);
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldDiscountedUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedUnitPriceSet", build);
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldDiscountedUnitPriceWithCodeDiscount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedUnitPriceWithCodeDiscount", build);
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("image", build);
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldOriginalTotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalTotalPriceSet", build);
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldOriginalUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalUnitPriceSet", build);
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
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

    public AbandonedCheckoutLineItemQueryBuilder AddFieldVariant(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("variant", build);
        return this;
    }

    public AbandonedCheckoutLineItemQueryBuilder AddFieldVariantTitle()
    {
        AddField("variantTitle");
        return this;
    }
}