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
    public sealed class DiscountAutomaticFreeShippingQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticFreeShipping, DiscountAutomaticFreeShippingQueryBuilder>
    {
        protected override DiscountAutomaticFreeShippingQueryBuilder Self => this;

        public DiscountAutomaticFreeShippingQueryBuilder() : this("discountAutomaticFreeShipping")
        {
        }

        public DiscountAutomaticFreeShippingQueryBuilder(string name) : base(new Query<DiscountAutomaticFreeShipping>(name))
        {
        }

        public DiscountAutomaticFreeShippingQueryBuilder(IQuery<DiscountAutomaticFreeShipping> query) : base(query)
        {
        }

        public DiscountAutomaticFreeShippingQueryBuilder AppliesOnOneTimePurchase()
        {
            base.InnerQuery.AddField("appliesOnOneTimePurchase");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder AppliesOnSubscription()
        {
            base.InnerQuery.AddField("appliesOnSubscription");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder AsyncUsageCount()
        {
            base.InnerQuery.AddField("asyncUsageCount");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder CombinesWith(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder> build)
        {
            var query = new Query<DiscountCombinesWith>("combinesWith");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCombinesWith>(query);
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public DiscountAutomaticFreeShippingQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder EndsAt()
        {
            base.InnerQuery.AddField("endsAt");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder MaximumShippingPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("maximumShippingPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder RecurringCycleLimit()
        {
            base.InnerQuery.AddField("recurringCycleLimit");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder ShortSummary()
        {
            base.InnerQuery.AddField("shortSummary");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder StartsAt()
        {
            base.InnerQuery.AddField("startsAt");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder Summary()
        {
            base.InnerQuery.AddField("summary");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder TotalSales(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSales");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder Context(Action<DiscountContextUnionCasesBuilder> build)
        {
            var query = new Query<DiscountContext>("context");
            var unionBuilder = new DiscountContextUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder DestinationSelection(Action<DiscountShippingDestinationSelectionUnionCasesBuilder> build)
        {
            var query = new Query<DiscountShippingDestinationSelection>("destinationSelection");
            var unionBuilder = new DiscountShippingDestinationSelectionUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public DiscountAutomaticFreeShippingQueryBuilder MinimumRequirement(Action<DiscountMinimumRequirementUnionCasesBuilder> build)
        {
            var query = new Query<DiscountMinimumRequirement>("minimumRequirement");
            var unionBuilder = new DiscountMinimumRequirementUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}