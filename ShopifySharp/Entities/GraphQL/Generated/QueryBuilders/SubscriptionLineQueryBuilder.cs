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

public class SubscriptionLineQueryBuilder() : GraphQueryBuilder<SubscriptionLine>("query subscriptionLine")
{
    public SubscriptionLineQueryBuilder AddFieldConcatenatedOriginContract()
    {
        AddField("concatenatedOriginContract");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldCurrentPrice()
    {
        AddField("currentPrice");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldCustomAttributes()
    {
        AddField("customAttributes");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldDiscountAllocations()
    {
        AddField("discountAllocations");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldLineDiscountedPrice()
    {
        AddField("lineDiscountedPrice");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldPricingPolicy()
    {
        AddField("pricingPolicy");
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

    public SubscriptionLineQueryBuilder AddFieldVariantImage()
    {
        AddField("variantImage");
        return this;
    }

    public SubscriptionLineQueryBuilder AddFieldVariantTitle()
    {
        AddField("variantTitle");
        return this;
    }
}