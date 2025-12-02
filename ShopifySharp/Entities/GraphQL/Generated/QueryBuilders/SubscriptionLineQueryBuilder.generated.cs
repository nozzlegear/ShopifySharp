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

public class SubscriptionLineQueryBuilder() : GraphQueryBuilder<SubscriptionLine>("subscriptionLine")
{
    public SubscriptionLineQueryBuilder AddFieldConcatenatedOriginContract(Func<SubscriptionContractQueryBuilder, SubscriptionContractQueryBuilder> build)
    {
        AddField<SubscriptionContract, SubscriptionContractQueryBuilder>("concatenatedOriginContract", build);
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldCurrentPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("currentPrice", build);
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldCustomAttributes(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("customAttributes", build);
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldDiscountAllocations(Func<SubscriptionDiscountAllocationQueryBuilder, SubscriptionDiscountAllocationQueryBuilder> build)
    {
        AddField<SubscriptionDiscountAllocation, SubscriptionDiscountAllocationQueryBuilder>("discountAllocations", build);
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldLineDiscountedPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("lineDiscountedPrice", build);
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldPricingPolicy(Func<SubscriptionPricingPolicyQueryBuilder, SubscriptionPricingPolicyQueryBuilder> build)
    {
        AddField<SubscriptionPricingPolicy, SubscriptionPricingPolicyQueryBuilder>("pricingPolicy", build);
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldProductId()
    {
        AddField("productId");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldRequiresShipping()
    {
        AddField("requiresShipping");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldSellingPlanId()
    {
        AddField("sellingPlanId");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldSellingPlanName()
    {
        AddField("sellingPlanName");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldSku()
    {
        AddField("sku");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldTaxable()
    {
        AddField("taxable");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldVariantId()
    {
        AddField("variantId");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldVariantImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("variantImage", build);
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldVariantTitle()
    {
        AddField("variantTitle");
        return this;
    }
}