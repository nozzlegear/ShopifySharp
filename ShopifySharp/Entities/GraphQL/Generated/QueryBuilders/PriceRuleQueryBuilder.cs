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

public class PriceRuleQueryBuilder() : GraphQueryBuilder<PriceRule>("query priceRule")
{
    public PriceRuleQueryBuilder AddFieldAllocationLimit()
    {
        AddField("allocationLimit");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldAllocationMethod()
    {
        AddField("allocationMethod");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldCombinesWith()
    {
        AddField("combinesWith");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldCustomerSelection()
    {
        AddField("customerSelection");
        return this;
    }

    [Obsolete("Use `discountClasses` instead.")]
    public PriceRuleQueryBuilder AddFieldDiscountClass()
    {
        AddField("discountClass");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldDiscountClasses()
    {
        AddField("discountClasses");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldDiscountCodes()
    {
        AddField("discountCodes");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldDiscountCodesCount()
    {
        AddField("discountCodesCount");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldEndsAt()
    {
        AddField("endsAt");
        return this;
    }

    [Obsolete("Use `prerequisiteToEntitlementQuantityRatio` instead.")]
    public PriceRuleQueryBuilder AddFieldEntitlementToPrerequisiteQuantityRatio()
    {
        AddField("entitlementToPrerequisiteQuantityRatio");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldEvents()
    {
        AddField("events");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldFeatures()
    {
        AddField("features");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldHasTimelineComment()
    {
        AddField("hasTimelineComment");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldItemEntitlements()
    {
        AddField("itemEntitlements");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldItemPrerequisites()
    {
        AddField("itemPrerequisites");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldLegacyResourceId()
    {
        AddField("legacyResourceId");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldOncePerCustomer()
    {
        AddField("oncePerCustomer");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldPrerequisiteQuantityRange()
    {
        AddField("prerequisiteQuantityRange");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldPrerequisiteShippingPriceRange()
    {
        AddField("prerequisiteShippingPriceRange");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldPrerequisiteSubtotalRange()
    {
        AddField("prerequisiteSubtotalRange");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldPrerequisiteToEntitlementQuantityRatio()
    {
        AddField("prerequisiteToEntitlementQuantityRatio");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldShareableUrls()
    {
        AddField("shareableUrls");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldShippingEntitlements()
    {
        AddField("shippingEntitlements");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldStartsAt()
    {
        AddField("startsAt");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldSummary()
    {
        AddField("summary");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldTarget()
    {
        AddField("target");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldTotalSales()
    {
        AddField("totalSales");
        return this;
    }

    [Obsolete("Use `features` instead.")]
    public PriceRuleQueryBuilder AddFieldTraits()
    {
        AddField("traits");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldUsageCount()
    {
        AddField("usageCount");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldUsageLimit()
    {
        AddField("usageLimit");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldValidityPeriod()
    {
        AddField("validityPeriod");
        return this;
    }

    [Obsolete("Use `valueV2` instead.")]
    public PriceRuleQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldValueV2()
    {
        AddField("valueV2");
        return this;
    }
}