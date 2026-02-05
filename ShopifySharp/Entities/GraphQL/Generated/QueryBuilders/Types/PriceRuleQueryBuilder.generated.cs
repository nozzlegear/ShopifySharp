#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class PriceRuleQueryBuilder : FieldsQueryBuilderBase<PriceRule, PriceRuleQueryBuilder>
    {
        protected override PriceRuleQueryBuilder Self => this;

        public PriceRuleQueryBuilder() : this("priceRule")
        {
        }

        public PriceRuleQueryBuilder(string name) : base(new Query<PriceRule>(name))
        {
        }

        public PriceRuleQueryBuilder(IQuery<PriceRule> query) : base(query)
        {
        }

        public PriceRuleQueryBuilder AllocationLimit()
        {
            base.InnerQuery.AddField("allocationLimit");
            return this;
        }

        public PriceRuleQueryBuilder AllocationMethod()
        {
            base.InnerQuery.AddField("allocationMethod");
            return this;
        }

        public PriceRuleQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public PriceRuleQueryBuilder CombinesWith(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder> build)
        {
            var query = new Query<DiscountCombinesWith>("combinesWith");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCombinesWith>(query);
            return this;
        }

        public PriceRuleQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public PriceRuleQueryBuilder CustomerSelection(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleCustomerSelectionQueryBuilder> build)
        {
            var query = new Query<PriceRuleCustomerSelection>("customerSelection");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleCustomerSelectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleCustomerSelection>(query);
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public PriceRuleQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public PriceRuleQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public PriceRuleQueryBuilder DiscountCodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleDiscountCodeConnectionQueryBuilder> build)
        {
            var query = new Query<PriceRuleDiscountCodeConnection>("discountCodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleDiscountCodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleDiscountCodeConnection>(query);
            return this;
        }

        public PriceRuleQueryBuilder DiscountCodesCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("discountCodesCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public PriceRuleQueryBuilder EndsAt()
        {
            base.InnerQuery.AddField("endsAt");
            return this;
        }

        public PriceRuleQueryBuilder EntitlementToPrerequisiteQuantityRatio(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleEntitlementToPrerequisiteQuantityRatioQueryBuilder> build)
        {
            var query = new Query<PriceRuleEntitlementToPrerequisiteQuantityRatio>("entitlementToPrerequisiteQuantityRatio");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleEntitlementToPrerequisiteQuantityRatioQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleEntitlementToPrerequisiteQuantityRatio>(query);
            return this;
        }

        public PriceRuleQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public PriceRuleQueryBuilder Features()
        {
            base.InnerQuery.AddField("features");
            return this;
        }

        public PriceRuleQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public PriceRuleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PriceRuleQueryBuilder ItemEntitlements(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleItemEntitlementsQueryBuilder> build)
        {
            var query = new Query<PriceRuleItemEntitlements>("itemEntitlements");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleItemEntitlementsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleItemEntitlements>(query);
            return this;
        }

        public PriceRuleQueryBuilder ItemPrerequisites(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleLineItemPrerequisitesQueryBuilder> build)
        {
            var query = new Query<PriceRuleLineItemPrerequisites>("itemPrerequisites");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleLineItemPrerequisitesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleLineItemPrerequisites>(query);
            return this;
        }

        public PriceRuleQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public PriceRuleQueryBuilder OncePerCustomer()
        {
            base.InnerQuery.AddField("oncePerCustomer");
            return this;
        }

        public PriceRuleQueryBuilder PrerequisiteQuantityRange(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleQuantityRangeQueryBuilder> build)
        {
            var query = new Query<PriceRuleQuantityRange>("prerequisiteQuantityRange");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleQuantityRangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleQuantityRange>(query);
            return this;
        }

        public PriceRuleQueryBuilder PrerequisiteShippingPriceRange(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleMoneyRangeQueryBuilder> build)
        {
            var query = new Query<PriceRuleMoneyRange>("prerequisiteShippingPriceRange");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleMoneyRangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleMoneyRange>(query);
            return this;
        }

        public PriceRuleQueryBuilder PrerequisiteSubtotalRange(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleMoneyRangeQueryBuilder> build)
        {
            var query = new Query<PriceRuleMoneyRange>("prerequisiteSubtotalRange");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleMoneyRangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleMoneyRange>(query);
            return this;
        }

        public PriceRuleQueryBuilder PrerequisiteToEntitlementQuantityRatio(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRulePrerequisiteToEntitlementQuantityRatioQueryBuilder> build)
        {
            var query = new Query<PriceRulePrerequisiteToEntitlementQuantityRatio>("prerequisiteToEntitlementQuantityRatio");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRulePrerequisiteToEntitlementQuantityRatioQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRulePrerequisiteToEntitlementQuantityRatio>(query);
            return this;
        }

        public PriceRuleQueryBuilder ShareableUrls(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleShareableUrlQueryBuilder> build)
        {
            var query = new Query<PriceRuleShareableUrl>("shareableUrls");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleShareableUrlQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleShareableUrl>(query);
            return this;
        }

        public PriceRuleQueryBuilder ShippingEntitlements(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleShippingLineEntitlementsQueryBuilder> build)
        {
            var query = new Query<PriceRuleShippingLineEntitlements>("shippingEntitlements");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleShippingLineEntitlementsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleShippingLineEntitlements>(query);
            return this;
        }

        public PriceRuleQueryBuilder StartsAt()
        {
            base.InnerQuery.AddField("startsAt");
            return this;
        }

        public PriceRuleQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public PriceRuleQueryBuilder Summary()
        {
            base.InnerQuery.AddField("summary");
            return this;
        }

        public PriceRuleQueryBuilder Target()
        {
            base.InnerQuery.AddField("target");
            return this;
        }

        public PriceRuleQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public PriceRuleQueryBuilder TotalSales(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSales");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        [Obsolete("Use `features` instead.")]
        public PriceRuleQueryBuilder Traits()
        {
            base.InnerQuery.AddField("traits");
            return this;
        }

        public PriceRuleQueryBuilder UsageCount()
        {
            base.InnerQuery.AddField("usageCount");
            return this;
        }

        public PriceRuleQueryBuilder UsageLimit()
        {
            base.InnerQuery.AddField("usageLimit");
            return this;
        }

        public PriceRuleQueryBuilder ValidityPeriod(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleValidityPeriodQueryBuilder> build)
        {
            var query = new Query<PriceRuleValidityPeriod>("validityPeriod");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PriceRuleValidityPeriodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceRuleValidityPeriod>(query);
            return this;
        }

        [Obsolete("Use `valueV2` instead.")]
        public PriceRuleQueryBuilder Value(Action<PriceRuleValueUnionCasesBuilder> build)
        {
            var query = new Query<PriceRuleValue>("value");
            var unionBuilder = new PriceRuleValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public PriceRuleQueryBuilder ValueV2(Action<PricingValueUnionCasesBuilder> build)
        {
            var query = new Query<PricingValue>("valueV2");
            var unionBuilder = new PricingValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}