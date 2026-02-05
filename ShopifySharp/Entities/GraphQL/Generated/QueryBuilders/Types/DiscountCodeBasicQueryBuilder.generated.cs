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
    public sealed class DiscountCodeBasicQueryBuilder : FieldsQueryBuilderBase<DiscountCodeBasic, DiscountCodeBasicQueryBuilder>
    {
        protected override DiscountCodeBasicQueryBuilder Self => this;

        public DiscountCodeBasicQueryBuilder() : this("discountCodeBasic")
        {
        }

        public DiscountCodeBasicQueryBuilder(string name) : base(new Query<DiscountCodeBasic>(name))
        {
        }

        public DiscountCodeBasicQueryBuilder(IQuery<DiscountCodeBasic> query) : base(query)
        {
        }

        public DiscountCodeBasicQueryBuilder AppliesOncePerCustomer()
        {
            base.InnerQuery.AddField("appliesOncePerCustomer");
            return this;
        }

        public DiscountCodeBasicQueryBuilder AsyncUsageCount()
        {
            base.InnerQuery.AddField("asyncUsageCount");
            return this;
        }

        public DiscountCodeBasicQueryBuilder Codes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeConnection>("codes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeConnection>(query);
            return this;
        }

        public DiscountCodeBasicQueryBuilder CodesCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("codesCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public DiscountCodeBasicQueryBuilder CombinesWith(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder> build)
        {
            var query = new Query<DiscountCombinesWith>("combinesWith");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCombinesWith>(query);
            return this;
        }

        public DiscountCodeBasicQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public DiscountCodeBasicQueryBuilder CustomerGets(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCustomerGetsQueryBuilder> build)
        {
            var query = new Query<DiscountCustomerGets>("customerGets");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCustomerGetsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCustomerGets>(query);
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public DiscountCodeBasicQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public DiscountCodeBasicQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public DiscountCodeBasicQueryBuilder EndsAt()
        {
            base.InnerQuery.AddField("endsAt");
            return this;
        }

        public DiscountCodeBasicQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public DiscountCodeBasicQueryBuilder RecurringCycleLimit()
        {
            base.InnerQuery.AddField("recurringCycleLimit");
            return this;
        }

        public DiscountCodeBasicQueryBuilder ShareableUrls(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountShareableUrlQueryBuilder> build)
        {
            var query = new Query<DiscountShareableUrl>("shareableUrls");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountShareableUrlQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountShareableUrl>(query);
            return this;
        }

        public DiscountCodeBasicQueryBuilder ShortSummary()
        {
            base.InnerQuery.AddField("shortSummary");
            return this;
        }

        public DiscountCodeBasicQueryBuilder StartsAt()
        {
            base.InnerQuery.AddField("startsAt");
            return this;
        }

        public DiscountCodeBasicQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public DiscountCodeBasicQueryBuilder Summary()
        {
            base.InnerQuery.AddField("summary");
            return this;
        }

        public DiscountCodeBasicQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public DiscountCodeBasicQueryBuilder TotalSales(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSales");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DiscountCodeBasicQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public DiscountCodeBasicQueryBuilder UsageLimit()
        {
            base.InnerQuery.AddField("usageLimit");
            return this;
        }

        public DiscountCodeBasicQueryBuilder Context(Action<DiscountContextUnionCasesBuilder> build)
        {
            var query = new Query<DiscountContext>("context");
            var unionBuilder = new DiscountContextUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        [Obsolete("Use `context` instead.")]
        public DiscountCodeBasicQueryBuilder CustomerSelection(Action<DiscountCustomerSelectionUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCustomerSelection>("customerSelection");
            var unionBuilder = new DiscountCustomerSelectionUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public DiscountCodeBasicQueryBuilder MinimumRequirement(Action<DiscountMinimumRequirementUnionCasesBuilder> build)
        {
            var query = new Query<DiscountMinimumRequirement>("minimumRequirement");
            var unionBuilder = new DiscountMinimumRequirementUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}