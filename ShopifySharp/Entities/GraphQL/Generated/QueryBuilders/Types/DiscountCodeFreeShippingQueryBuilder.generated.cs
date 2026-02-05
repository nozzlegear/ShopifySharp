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
    public sealed class DiscountCodeFreeShippingQueryBuilder : FieldsQueryBuilderBase<DiscountCodeFreeShipping, DiscountCodeFreeShippingQueryBuilder>
    {
        protected override DiscountCodeFreeShippingQueryBuilder Self => this;

        public DiscountCodeFreeShippingQueryBuilder() : this("discountCodeFreeShipping")
        {
        }

        public DiscountCodeFreeShippingQueryBuilder(string name) : base(new Query<DiscountCodeFreeShipping>(name))
        {
        }

        public DiscountCodeFreeShippingQueryBuilder(IQuery<DiscountCodeFreeShipping> query) : base(query)
        {
        }

        public DiscountCodeFreeShippingQueryBuilder AppliesOncePerCustomer()
        {
            base.InnerQuery.AddField("appliesOncePerCustomer");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder AppliesOnOneTimePurchase()
        {
            base.InnerQuery.AddField("appliesOnOneTimePurchase");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder AppliesOnSubscription()
        {
            base.InnerQuery.AddField("appliesOnSubscription");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder AsyncUsageCount()
        {
            base.InnerQuery.AddField("asyncUsageCount");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder Codes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeConnection>("codes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeConnection>(query);
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder CodesCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("codesCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder CombinesWith(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder> build)
        {
            var query = new Query<DiscountCombinesWith>("combinesWith");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCombinesWith>(query);
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public DiscountCodeFreeShippingQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder EndsAt()
        {
            base.InnerQuery.AddField("endsAt");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder MaximumShippingPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("maximumShippingPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder RecurringCycleLimit()
        {
            base.InnerQuery.AddField("recurringCycleLimit");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder ShareableUrls(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountShareableUrlQueryBuilder> build)
        {
            var query = new Query<DiscountShareableUrl>("shareableUrls");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountShareableUrlQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountShareableUrl>(query);
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder ShortSummary()
        {
            base.InnerQuery.AddField("shortSummary");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder StartsAt()
        {
            base.InnerQuery.AddField("startsAt");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder Summary()
        {
            base.InnerQuery.AddField("summary");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder TotalSales(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSales");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder UsageLimit()
        {
            base.InnerQuery.AddField("usageLimit");
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder Context(Action<DiscountContextUnionCasesBuilder> build)
        {
            var query = new Query<DiscountContext>("context");
            var unionBuilder = new DiscountContextUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        [Obsolete("Use `context` instead.")]
        public DiscountCodeFreeShippingQueryBuilder CustomerSelection(Action<DiscountCustomerSelectionUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCustomerSelection>("customerSelection");
            var unionBuilder = new DiscountCustomerSelectionUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder DestinationSelection(Action<DiscountShippingDestinationSelectionUnionCasesBuilder> build)
        {
            var query = new Query<DiscountShippingDestinationSelection>("destinationSelection");
            var unionBuilder = new DiscountShippingDestinationSelectionUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public DiscountCodeFreeShippingQueryBuilder MinimumRequirement(Action<DiscountMinimumRequirementUnionCasesBuilder> build)
        {
            var query = new Query<DiscountMinimumRequirement>("minimumRequirement");
            var unionBuilder = new DiscountMinimumRequirementUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}