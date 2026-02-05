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
    public sealed class DiscountAutomaticAppQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticApp, DiscountAutomaticAppQueryBuilder>
    {
        protected override DiscountAutomaticAppQueryBuilder Self => this;

        public DiscountAutomaticAppQueryBuilder() : this("discountAutomaticApp")
        {
        }

        public DiscountAutomaticAppQueryBuilder(string name) : base(new Query<DiscountAutomaticApp>(name))
        {
        }

        public DiscountAutomaticAppQueryBuilder(IQuery<DiscountAutomaticApp> query) : base(query)
        {
        }

        public DiscountAutomaticAppQueryBuilder AppDiscountType(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppDiscountTypeQueryBuilder> build)
        {
            var query = new Query<AppDiscountType>("appDiscountType");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppDiscountTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppDiscountType>(query);
            return this;
        }

        public DiscountAutomaticAppQueryBuilder AppliesOnOneTimePurchase()
        {
            base.InnerQuery.AddField("appliesOnOneTimePurchase");
            return this;
        }

        public DiscountAutomaticAppQueryBuilder AppliesOnSubscription()
        {
            base.InnerQuery.AddField("appliesOnSubscription");
            return this;
        }

        public DiscountAutomaticAppQueryBuilder AsyncUsageCount()
        {
            base.InnerQuery.AddField("asyncUsageCount");
            return this;
        }

        public DiscountAutomaticAppQueryBuilder CombinesWith(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder> build)
        {
            var query = new Query<DiscountCombinesWith>("combinesWith");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCombinesWith>(query);
            return this;
        }

        public DiscountAutomaticAppQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public DiscountAutomaticAppQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public DiscountAutomaticAppQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public DiscountAutomaticAppQueryBuilder DiscountId()
        {
            base.InnerQuery.AddField("discountId");
            return this;
        }

        public DiscountAutomaticAppQueryBuilder EndsAt()
        {
            base.InnerQuery.AddField("endsAt");
            return this;
        }

        public DiscountAutomaticAppQueryBuilder ErrorHistory(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsErrorHistoryQueryBuilder> build)
        {
            var query = new Query<FunctionsErrorHistory>("errorHistory");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsErrorHistoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FunctionsErrorHistory>(query);
            return this;
        }

        public DiscountAutomaticAppQueryBuilder RecurringCycleLimit()
        {
            base.InnerQuery.AddField("recurringCycleLimit");
            return this;
        }

        public DiscountAutomaticAppQueryBuilder StartsAt()
        {
            base.InnerQuery.AddField("startsAt");
            return this;
        }

        public DiscountAutomaticAppQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public DiscountAutomaticAppQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public DiscountAutomaticAppQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public DiscountAutomaticAppQueryBuilder Context(Action<DiscountContextUnionCasesBuilder> build)
        {
            var query = new Query<DiscountContext>("context");
            var unionBuilder = new DiscountContextUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}