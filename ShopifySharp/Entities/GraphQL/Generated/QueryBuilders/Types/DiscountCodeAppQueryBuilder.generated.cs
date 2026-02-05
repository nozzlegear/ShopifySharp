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
    public sealed class DiscountCodeAppQueryBuilder : FieldsQueryBuilderBase<DiscountCodeApp, DiscountCodeAppQueryBuilder>
    {
        protected override DiscountCodeAppQueryBuilder Self => this;

        public DiscountCodeAppQueryBuilder() : this("discountCodeApp")
        {
        }

        public DiscountCodeAppQueryBuilder(string name) : base(new Query<DiscountCodeApp>(name))
        {
        }

        public DiscountCodeAppQueryBuilder(IQuery<DiscountCodeApp> query) : base(query)
        {
        }

        public DiscountCodeAppQueryBuilder AppDiscountType(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppDiscountTypeQueryBuilder> build)
        {
            var query = new Query<AppDiscountType>("appDiscountType");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppDiscountTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppDiscountType>(query);
            return this;
        }

        public DiscountCodeAppQueryBuilder AppliesOncePerCustomer()
        {
            base.InnerQuery.AddField("appliesOncePerCustomer");
            return this;
        }

        public DiscountCodeAppQueryBuilder AppliesOnOneTimePurchase()
        {
            base.InnerQuery.AddField("appliesOnOneTimePurchase");
            return this;
        }

        public DiscountCodeAppQueryBuilder AppliesOnSubscription()
        {
            base.InnerQuery.AddField("appliesOnSubscription");
            return this;
        }

        public DiscountCodeAppQueryBuilder AsyncUsageCount()
        {
            base.InnerQuery.AddField("asyncUsageCount");
            return this;
        }

        public DiscountCodeAppQueryBuilder Codes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeConnection>("codes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeConnection>(query);
            return this;
        }

        public DiscountCodeAppQueryBuilder CodesCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("codesCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public DiscountCodeAppQueryBuilder CombinesWith(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder> build)
        {
            var query = new Query<DiscountCombinesWith>("combinesWith");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCombinesWithQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCombinesWith>(query);
            return this;
        }

        public DiscountCodeAppQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public DiscountCodeAppQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public DiscountCodeAppQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public DiscountCodeAppQueryBuilder DiscountId()
        {
            base.InnerQuery.AddField("discountId");
            return this;
        }

        public DiscountCodeAppQueryBuilder EndsAt()
        {
            base.InnerQuery.AddField("endsAt");
            return this;
        }

        public DiscountCodeAppQueryBuilder ErrorHistory(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsErrorHistoryQueryBuilder> build)
        {
            var query = new Query<FunctionsErrorHistory>("errorHistory");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsErrorHistoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FunctionsErrorHistory>(query);
            return this;
        }

        public DiscountCodeAppQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public DiscountCodeAppQueryBuilder RecurringCycleLimit()
        {
            base.InnerQuery.AddField("recurringCycleLimit");
            return this;
        }

        public DiscountCodeAppQueryBuilder ShareableUrls(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountShareableUrlQueryBuilder> build)
        {
            var query = new Query<DiscountShareableUrl>("shareableUrls");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountShareableUrlQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountShareableUrl>(query);
            return this;
        }

        public DiscountCodeAppQueryBuilder StartsAt()
        {
            base.InnerQuery.AddField("startsAt");
            return this;
        }

        public DiscountCodeAppQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public DiscountCodeAppQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public DiscountCodeAppQueryBuilder TotalSales(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSales");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DiscountCodeAppQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public DiscountCodeAppQueryBuilder UsageLimit()
        {
            base.InnerQuery.AddField("usageLimit");
            return this;
        }

        public DiscountCodeAppQueryBuilder Context(Action<DiscountContextUnionCasesBuilder> build)
        {
            var query = new Query<DiscountContext>("context");
            var unionBuilder = new DiscountContextUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        [Obsolete("Use `context` instead.")]
        public DiscountCodeAppQueryBuilder CustomerSelection(Action<DiscountCustomerSelectionUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCustomerSelection>("customerSelection");
            var unionBuilder = new DiscountCustomerSelectionUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}