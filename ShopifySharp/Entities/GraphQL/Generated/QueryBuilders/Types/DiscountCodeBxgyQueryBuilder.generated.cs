#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class DiscountCodeBxgyQueryBuilder : FieldsQueryBuilderBase<DiscountCodeBxgy, DiscountCodeBxgyQueryBuilder>
    {
        protected override DiscountCodeBxgyQueryBuilder Self => this;

        public DiscountCodeBxgyQueryBuilder() : this("discountCodeBxgy")
        {
        }

        public DiscountCodeBxgyQueryBuilder(string name) : base(new Query<DiscountCodeBxgy>(name))
        {
        }

        public DiscountCodeBxgyQueryBuilder(IQuery<DiscountCodeBxgy> query) : base(query)
        {
        }

        public DiscountCodeBxgyQueryBuilder AppliesOncePerCustomer()
        {
            base.InnerQuery.AddField("appliesOncePerCustomer");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder AsyncUsageCount()
        {
            base.InnerQuery.AddField("asyncUsageCount");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder Codes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeConnection>("codes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeConnection>(query);
            return this;
        }

        public DiscountCodeBxgyQueryBuilder CodesCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("codesCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public DiscountCodeBxgyQueryBuilder CombinesWith(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCombinesWithQueryBuilder> build)
        {
            var query = new Query<DiscountCombinesWith>("combinesWith");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCombinesWithQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCombinesWith>(query);
            return this;
        }

        public DiscountCodeBxgyQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder CustomerBuys(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerBuysQueryBuilder> build)
        {
            var query = new Query<DiscountCustomerBuys>("customerBuys");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerBuysQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCustomerBuys>(query);
            return this;
        }

        public DiscountCodeBxgyQueryBuilder CustomerGets(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerGetsQueryBuilder> build)
        {
            var query = new Query<DiscountCustomerGets>("customerGets");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCustomerGetsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCustomerGets>(query);
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public DiscountCodeBxgyQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder EndsAt()
        {
            base.InnerQuery.AddField("endsAt");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder ShareableUrls(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountShareableUrlQueryBuilder> build)
        {
            var query = new Query<DiscountShareableUrl>("shareableUrls");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountShareableUrlQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountShareableUrl>(query);
            return this;
        }

        public DiscountCodeBxgyQueryBuilder StartsAt()
        {
            base.InnerQuery.AddField("startsAt");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder Summary()
        {
            base.InnerQuery.AddField("summary");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder TotalSales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DiscountCodeBxgyQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder UsageLimit()
        {
            base.InnerQuery.AddField("usageLimit");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder UsesPerOrderLimit()
        {
            base.InnerQuery.AddField("usesPerOrderLimit");
            return this;
        }

        public DiscountCodeBxgyQueryBuilder Context(Action<DiscountContextUnionCasesBuilder> build)
        {
            var query = new Query<DiscountContext>("context");
            var unionBuilder = new DiscountContextUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        [Obsolete("Use `context` instead.")]
        public DiscountCodeBxgyQueryBuilder CustomerSelection(Action<DiscountCustomerSelectionUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCustomerSelection>("customerSelection");
            var unionBuilder = new DiscountCustomerSelectionUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}