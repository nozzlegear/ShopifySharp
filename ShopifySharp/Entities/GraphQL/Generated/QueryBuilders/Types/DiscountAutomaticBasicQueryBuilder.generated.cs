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
    public sealed class DiscountAutomaticBasicQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticBasic, DiscountAutomaticBasicQueryBuilder>
    {
        protected override DiscountAutomaticBasicQueryBuilder Self => this;

        public DiscountAutomaticBasicQueryBuilder() : this("discountAutomaticBasic")
        {
        }

        public DiscountAutomaticBasicQueryBuilder(string name) : base(new Query<DiscountAutomaticBasic>(name))
        {
        }

        public DiscountAutomaticBasicQueryBuilder(IQuery<DiscountAutomaticBasic> query) : base(query)
        {
        }

        public DiscountAutomaticBasicQueryBuilder AsyncUsageCount()
        {
            base.InnerQuery.AddField("asyncUsageCount");
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder CombinesWith(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder> build)
        {
            var query = new Query<DiscountCombinesWith>("combinesWith");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCombinesWith>(query);
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder CustomerGets(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCustomerGetsQueryBuilder> build)
        {
            var query = new Query<DiscountCustomerGets>("customerGets");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCustomerGetsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCustomerGets>(query);
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public DiscountAutomaticBasicQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder EndsAt()
        {
            base.InnerQuery.AddField("endsAt");
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder RecurringCycleLimit()
        {
            base.InnerQuery.AddField("recurringCycleLimit");
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder ShortSummary()
        {
            base.InnerQuery.AddField("shortSummary");
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder StartsAt()
        {
            base.InnerQuery.AddField("startsAt");
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder Summary()
        {
            base.InnerQuery.AddField("summary");
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        [Obsolete("Use `asyncUsageCount` instead.")]
        public DiscountAutomaticBasicQueryBuilder UsageCount()
        {
            base.InnerQuery.AddField("usageCount");
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder Context(Action<DiscountContextUnionCasesBuilder> build)
        {
            var query = new Query<DiscountContext>("context");
            var unionBuilder = new DiscountContextUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public DiscountAutomaticBasicQueryBuilder MinimumRequirement(Action<DiscountMinimumRequirementUnionCasesBuilder> build)
        {
            var query = new Query<DiscountMinimumRequirement>("minimumRequirement");
            var unionBuilder = new DiscountMinimumRequirementUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}