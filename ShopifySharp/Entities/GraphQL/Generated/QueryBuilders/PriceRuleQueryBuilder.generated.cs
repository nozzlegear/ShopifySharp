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

public class PriceRuleQueryBuilder() : GraphQueryBuilder<PriceRule>("priceRule")
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

    public PriceRuleQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public PriceRuleQueryBuilder AddFieldCombinesWith(Func<DiscountCombinesWithQueryBuilder, DiscountCombinesWithQueryBuilder> build)
    {
        AddField<DiscountCombinesWith, DiscountCombinesWithQueryBuilder>("combinesWith", build);
        return this;
    }

    public PriceRuleQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldCustomerSelection(Func<PriceRuleCustomerSelectionQueryBuilder, PriceRuleCustomerSelectionQueryBuilder> build)
    {
        AddField<PriceRuleCustomerSelection, PriceRuleCustomerSelectionQueryBuilder>("customerSelection", build);
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

    public PriceRuleQueryBuilder AddFieldDiscountCodes(Func<PriceRuleDiscountCodeConnectionQueryBuilder, PriceRuleDiscountCodeConnectionQueryBuilder> build)
    {
        AddField<PriceRuleDiscountCodeConnection, PriceRuleDiscountCodeConnectionQueryBuilder>("discountCodes", build);
        return this;
    }

    public PriceRuleQueryBuilder AddFieldDiscountCodesCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("discountCodesCount", build);
        return this;
    }

    public PriceRuleQueryBuilder AddFieldEndsAt()
    {
        AddField("endsAt");
        return this;
    }

    public PriceRuleQueryBuilder AddFieldEntitlementToPrerequisiteQuantityRatio(Func<PriceRuleEntitlementToPrerequisiteQuantityRatioQueryBuilder, PriceRuleEntitlementToPrerequisiteQuantityRatioQueryBuilder> build)
    {
        AddField<PriceRuleEntitlementToPrerequisiteQuantityRatio, PriceRuleEntitlementToPrerequisiteQuantityRatioQueryBuilder>("entitlementToPrerequisiteQuantityRatio", build);
        return this;
    }

    public PriceRuleQueryBuilder AddFieldEvents(Func<EventConnectionQueryBuilder, EventConnectionQueryBuilder> build)
    {
        AddField<EventConnection, EventConnectionQueryBuilder>("events", build);
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

    public PriceRuleQueryBuilder AddFieldItemEntitlements(Func<PriceRuleItemEntitlementsQueryBuilder, PriceRuleItemEntitlementsQueryBuilder> build)
    {
        AddField<PriceRuleItemEntitlements, PriceRuleItemEntitlementsQueryBuilder>("itemEntitlements", build);
        return this;
    }

    public PriceRuleQueryBuilder AddFieldItemPrerequisites(Func<PriceRuleLineItemPrerequisitesQueryBuilder, PriceRuleLineItemPrerequisitesQueryBuilder> build)
    {
        AddField<PriceRuleLineItemPrerequisites, PriceRuleLineItemPrerequisitesQueryBuilder>("itemPrerequisites", build);
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

    public PriceRuleQueryBuilder AddFieldPrerequisiteQuantityRange(Func<PriceRuleQuantityRangeQueryBuilder, PriceRuleQuantityRangeQueryBuilder> build)
    {
        AddField<PriceRuleQuantityRange, PriceRuleQuantityRangeQueryBuilder>("prerequisiteQuantityRange", build);
        return this;
    }

    public PriceRuleQueryBuilder AddFieldPrerequisiteShippingPriceRange(Func<PriceRuleMoneyRangeQueryBuilder, PriceRuleMoneyRangeQueryBuilder> build)
    {
        AddField<PriceRuleMoneyRange, PriceRuleMoneyRangeQueryBuilder>("prerequisiteShippingPriceRange", build);
        return this;
    }

    public PriceRuleQueryBuilder AddFieldPrerequisiteSubtotalRange(Func<PriceRuleMoneyRangeQueryBuilder, PriceRuleMoneyRangeQueryBuilder> build)
    {
        AddField<PriceRuleMoneyRange, PriceRuleMoneyRangeQueryBuilder>("prerequisiteSubtotalRange", build);
        return this;
    }

    public PriceRuleQueryBuilder AddFieldPrerequisiteToEntitlementQuantityRatio(Func<PriceRulePrerequisiteToEntitlementQuantityRatioQueryBuilder, PriceRulePrerequisiteToEntitlementQuantityRatioQueryBuilder> build)
    {
        AddField<PriceRulePrerequisiteToEntitlementQuantityRatio, PriceRulePrerequisiteToEntitlementQuantityRatioQueryBuilder>("prerequisiteToEntitlementQuantityRatio", build);
        return this;
    }

    public PriceRuleQueryBuilder AddFieldShareableUrls(Func<PriceRuleShareableUrlQueryBuilder, PriceRuleShareableUrlQueryBuilder> build)
    {
        AddField<PriceRuleShareableUrl, PriceRuleShareableUrlQueryBuilder>("shareableUrls", build);
        return this;
    }

    public PriceRuleQueryBuilder AddFieldShippingEntitlements(Func<PriceRuleShippingLineEntitlementsQueryBuilder, PriceRuleShippingLineEntitlementsQueryBuilder> build)
    {
        AddField<PriceRuleShippingLineEntitlements, PriceRuleShippingLineEntitlementsQueryBuilder>("shippingEntitlements", build);
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

    public PriceRuleQueryBuilder AddFieldTotalSales(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("totalSales", build);
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

    public PriceRuleQueryBuilder AddFieldValidityPeriod(Func<PriceRuleValidityPeriodQueryBuilder, PriceRuleValidityPeriodQueryBuilder> build)
    {
        AddField<PriceRuleValidityPeriod, PriceRuleValidityPeriodQueryBuilder>("validityPeriod", build);
        return this;
    }

    public PriceRuleQueryBuilder AddUnionCaseValue(Func<PriceRuleFixedAmountValueQueryBuilder, PriceRuleFixedAmountValueQueryBuilder> build)
    {
        AddUnion<PriceRuleFixedAmountValue, PriceRuleFixedAmountValueQueryBuilder>("value", build);
        return this;
    }

    public PriceRuleQueryBuilder AddUnionCaseValue(Func<PriceRulePercentValueQueryBuilder, PriceRulePercentValueQueryBuilder> build)
    {
        AddUnion<PriceRulePercentValue, PriceRulePercentValueQueryBuilder>("value", build);
        return this;
    }

    public PriceRuleQueryBuilder AddUnionCaseValueV2(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddUnion<MoneyV2, MoneyV2QueryBuilder>("valueV2", build);
        return this;
    }

    public PriceRuleQueryBuilder AddUnionCaseValueV2(Func<PricingPercentageValueQueryBuilder, PricingPercentageValueQueryBuilder> build)
    {
        AddUnion<PricingPercentageValue, PricingPercentageValueQueryBuilder>("valueV2", build);
        return this;
    }
}